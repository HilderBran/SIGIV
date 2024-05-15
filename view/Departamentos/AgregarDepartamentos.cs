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


namespace view.Departamentos
{
    public partial class AgregarDepartamentos : Form
    {
        private DepartamentoController departamento = null!;
        public AgregarDepartamentos(DepartamentoController departamento = null!)
        {
            InitializeComponent();
            this.departamento = departamento;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (departamento == null)
            {
                await Guardar();
            }
            else
            {
                await Actualizar();
            }
        }

        private async Task Actualizar()
        {
            try
            {
                departamento.Nombre = txbDepartamento.Text;
                departamento.IdPais = cbbIdPais.SelectedValue?.ToString()!;

                var result = await departamento.Editar();

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task CargarPaises()
        {
            try
            {
                var paises = await Controller.PaisController.Paises();
                cbbIdPais.DataSource = paises;
                cbbIdPais.DisplayMember = "Pais";
                cbbIdPais.ValueMember = "IdPais";
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            await CargarPaises();
            if(departamento != null)
            {
                txbIdDepartamento.Text = departamento.Id;
                txbDepartamento.Text = departamento.Nombre;
                cbbIdPais.SelectedValue = departamento.IdPais;
            }
            base.OnLoad(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task Guardar()
        {
            try
            {
                var departamento = new DepartamentoController
                {
                    Id = txbIdDepartamento.Text,
                    Nombre = txbDepartamento.Text,
                    IdPais = cbbIdPais.SelectedValue?.ToString()!
                };

                var result = await departamento.Agregar();

                if (result)
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
