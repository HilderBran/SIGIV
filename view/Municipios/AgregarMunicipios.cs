using Controller;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Municipios
{
    public partial class AgregarMunicipios : Form
    {
        private MunicipioController municipio;
        public AgregarMunicipios(MunicipioController municipio = null!)
        {
            InitializeComponent();
            this.municipio = municipio;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (municipio == null)
            {
                await Guardarmunicipio();
            }
            else
            {
                await ActualizarMunicipio();
            }
        }

        private async Task ActualizarMunicipio()
        {
            try
            {
                municipio.Id = txbIdMunicipio.Text;
                municipio.Nombre = txbMunicipio.Text;
                municipio.IdDepartamento = cbbIdDepartamento?.SelectedValue?.ToString() ?? "";
                bool bandera = await municipio.UpdateMunicipio();

                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el municipio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            this.Text = "Agregar Municipio";
            await CargarDepartamentos();
            if (municipio != null)
            {
                this.Text = "Editar Municipio";
                txbIdMunicipio.Text = municipio.Id;
                txbMunicipio.Text = municipio.Nombre;
                cbbIdDepartamento.SelectedValue = municipio.IdDepartamento;
            }
            base.OnLoad(e);
        }

        private async Task Guardarmunicipio()
        {
            try
            {
                Controller.MunicipioController municipioController = new Controller.MunicipioController();
                municipioController.Id = txbIdMunicipio.Text;
                municipioController.Nombre = txbMunicipio.Text;
                municipioController.IdDepartamento = cbbIdDepartamento?.SelectedValue?.ToString() ?? "";
                bool bandera = await municipioController.AddMunicipio();

                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el municipio");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public async Task CargarDepartamentos()
        {
            try
            {
                var departamentos = await Controller.DepartamentoController.GetDepartamentos();
                cbbIdDepartamento.DataSource = departamentos;
                cbbIdDepartamento.DisplayMember = "Nombre";
                cbbIdDepartamento.ValueMember = "Id";
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AgregarMunicipios_Load(object sender, EventArgs e)
        {

        }
    }
}
