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
using view.Municipios;

namespace view.Distritos
{
    public partial class GestionDistritos : Form
    {
        public GestionDistritos()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDistritos agregarDistritos = new AgregarDistritos();
            var result = agregarDistritos.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Municipio agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await cargarDistrito();
            }
        }

        private async Task cargarDistrito()
        {
            try
            {
                var distritos = await DistritoController.GetDistritos();
                dgvDistritos.DataSource = distritos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            await cargarDistrito();
            base.OnLoad(e);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDistritos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un distrito");
                return;
            }
            var distrito = (DistritoController)dgvDistritos.SelectedRows[0].DataBoundItem;
            AgregarDistritos agregarDistritos = new AgregarDistritos(distrito);
            var result = agregarDistritos.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Distrito actualizado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await cargarDistrito();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDistritos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un distrito");
                return;
            }
            var distrito = (DistritoController)dgvDistritos.SelectedRows[0].DataBoundItem;
            if (MessageBox.Show("¿Está seguro de eliminar el distrito?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool bandera = await distrito.DeteleDistrito();
                if (bandera)
                {
                    MessageBox.Show("Distrito eliminado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await cargarDistrito();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el distrito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var distritos = await DistritoController.FiltrarDistritos(txbFiltrar.Text);
                dgvDistritos.DataSource = distritos;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al filtrar los distritos");
            }
        }
    }
}
