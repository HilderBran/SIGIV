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
    public partial class GestionMunicipios : Form
    {
        public GestionMunicipios()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMunicipios agregarMunicipios = new AgregarMunicipios();
            var result = agregarMunicipios.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Municipio agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await cargarMunicipios();
            }
        }

        private async Task cargarMunicipios()
        {
            try
            {
                var municipios = await MunicipioController.GetMunicipios();
                dgvMunicipios.DataSource = municipios;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        protected override async void OnLoad(EventArgs e)
        {
            await cargarMunicipios();
            base.OnLoad(e);
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvMunicipios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un municipio");
                return;
            }
            var municipio = (MunicipioController)dgvMunicipios.SelectedRows[0].DataBoundItem;
            AgregarMunicipios agregarMunicipios = new AgregarMunicipios(municipio);
            var result = agregarMunicipios.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Municipio actualizado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await cargarMunicipios();
            }
        }

        private async void txbFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var municipios = await MunicipioController.FiltrarMunicipios(txbFiltrar.Text);
                dgvMunicipios.DataSource = municipios;
            }
            catch (Exception)
            {

                MessageBox.Show("Error al filtrar los municipios");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMunicipios.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un municipio");
                    return;
                }
                var municipio = (MunicipioController)dgvMunicipios.SelectedRows[0].DataBoundItem;
                DialogResult result = MessageBox.Show("¿Está seguro de eliminar el municipio?", "Eliminar municipio", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    await municipio.DeteleMunicipio();
                    await cargarMunicipios();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el municipio");
            }
        }
    }
}
