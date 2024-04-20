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

namespace view.Pais
{
    public partial class GestionPais : Form
    {
        private AgregarPais agregarPais;
        private PaisController paisController;
        public GestionPais(AgregarPais agregarPais, PaisController paisController)
        {
            InitializeComponent();
            this.agregarPais = agregarPais;
            this.paisController = paisController;
        }

        private async Task cargarDatos()
        {
            var paises = await this.paisController.GetPaises();
            dgvpaises.DataSource = paises;
        }

        protected async override void OnLoad(EventArgs e)
        {
            await cargarDatos();
            base.OnLoad(e);
        }

        private void agregarpais_Click(object sender, EventArgs e)
        {
            AgregarPais.editarpais = null!;
            this.agregarPais.ShowDialog();
        }

        private async void actualizarpaises_Click(object sender, EventArgs e)
        {

            await cargarDatos();
        }

        private void editarpais_Click(object sender, EventArgs e)
        {
            agregarPais.ShowDialog();
        }

        private void dgvpaises_SelectionChanged(object sender, EventArgs e)
        {
            var datagrid=(DataGridView)sender;
            if (datagrid.SelectedRows.Count>0)
            {
                DataGridViewRow viewRow = datagrid.SelectedRows[0];
                AgregarPais.editarpais.IdPais = viewRow.Cells["IdPais"].Value.ToString()!;
                AgregarPais.editarpais.Pais= viewRow.Cells["Pais"].Value.ToString()!;
                
            }
        }
    }
}
