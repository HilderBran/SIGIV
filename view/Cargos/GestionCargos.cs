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
using view.Distritos;

namespace view.Cargos
{
    public partial class GestionCargos : Form
    {
        public GestionCargos()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCargos agregarCargos = new AgregarCargos();
            var result = agregarCargos.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Municipio agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarCargos();
            }
        }

        private async Task CargarCargos()
        {
            try
            {
                var cargos = await CargoController.GetCargos();
                dgvCargos.DataSource = cargos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            await CargarCargos();
            base.OnLoad(e);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cargo = dgvCargos.SelectedRows[0].DataBoundItem as CargoController;
            AgregarCargos agregarCargos = new AgregarCargos(cargo!);
            var result = agregarCargos.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Cargo actualizado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarCargos();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCargos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var cargo = dgvCargos.SelectedRows[0].DataBoundItem as CargoController;
            var result = MessageBox.Show("¿Está seguro de eliminar el cargo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool bandera = await cargo!.DeteleCargo();
                    if (bandera)
                    {
                        MessageBox.Show("Cargo eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarCargos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var cargos = CargoController.FiltrarCargos(txbFiltrar.Text);
                dgvCargos.DataSource = cargos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
