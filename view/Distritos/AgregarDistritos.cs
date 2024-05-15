using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Distritos
{
    public partial class AgregarDistritos : Form
    {
        private DistritoController distrito;
        public AgregarDistritos(DistritoController distrito = null!)
        {
            InitializeComponent();
            this.distrito = distrito;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (distrito == null)
            {
                await GuardarDistrito();
            }
            else
            {
                await ActualizarDistrito();
            }
        }

        private async Task ActualizarDistrito()
        {
            try
            {
                distrito.Id = txbIdDistrito.Text;
                distrito.Nombre = txbDistrito.Text;
                distrito.IdMunicipio = cbbIdMunicipio?.SelectedValue?.ToString() ?? "";
                bool bandera = await distrito.UpdateDistrito();

                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el distrito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task GuardarDistrito()
        {
            try
            {
                DistritoController distrito = new DistritoController
                {
                    Id = txbIdDistrito.Text,
                    Nombre = txbDistrito.Text,
                    IdMunicipio = cbbIdMunicipio?.SelectedValue?.ToString() ?? ""
                };
                bool bandera = await distrito.AddDistrito();

                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el distrito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task CargarMunicipios()
        {
            try
            {
                List<MunicipioController> municipios = await MunicipioController.GetMunicipios();
                cbbIdMunicipio.DataSource = municipios;
                cbbIdMunicipio.DisplayMember = "Nombre";
                cbbIdMunicipio.ValueMember = "Id";
                if (distrito != null)
                {
                    cbbIdMunicipio.SelectedValue = distrito.IdMunicipio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            this.Text = "Agregar Distrito";
            await CargarMunicipios();
            if (distrito != null)
            {
                this.Text = "Editar Distrito";
                txbIdDistrito.Text = distrito.Id;
                txbDistrito.Text = distrito.Nombre;
                cbbIdMunicipio.SelectedValue = distrito.IdMunicipio;
            }
            base.OnLoad(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
