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
    public partial class GestionDepartamento : Form
    {
        public GestionDepartamento()
        {
            InitializeComponent();
        }

        private async void tsbAgregar_Click(object sender, EventArgs e)
        {
            var agregarDepartamento = new AgregarDepartamentos();
            var result = agregarDepartamento.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Departamento agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarDepartamentos();
            }
        }

        private async Task CargarDepartamentos()
        {
            try
            {
                var departamentos = await Controller.DepartamentoController.GetDepartamentos();
                dgvDepartamentos.DataSource = departamentos;
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected async override void OnLoad(EventArgs e)
        {
            await CargarDepartamentos();
            base.OnLoad(e);
        }

        private async void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var departamento = dgvDepartamentos.SelectedRows[0].DataBoundItem as DepartamentoController;
                var result = MessageBox.Show($"¿Está seguro de eliminar el departamento {departamento?.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var resultDelete = await departamento!.Eliminar();
                    if (resultDelete)
                    {
                        MessageBox.Show("Departamento eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarDepartamentos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void stbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDepartamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione un departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var departamento = dgvDepartamentos.SelectedRows[0].DataBoundItem as DepartamentoController;
                var editarDepartamento = new AgregarDepartamentos(departamento!);
                var result = editarDepartamento.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Departamento actualizado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarDepartamentos();
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tstbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tstbFiltrar.Text.Length > 0)
                {
                    var departamentos = await Controller.DepartamentoController.Buscar(tstbFiltrar.Text);
                    dgvDepartamentos.DataSource = departamentos;
                }
                else
                {
                    await CargarDepartamentos();
                }
            }
            catch (Exception xp)
            {
                MessageBox.Show(xp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
