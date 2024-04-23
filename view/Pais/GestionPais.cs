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
            if (dgvpaises.SelectedRows.Count >= 0)
            {
                AgregarPais.editarpais = new Paise();
                AgregarPais.editarpais.IdPais = dgvpaises.CurrentRow.Cells[0].Value.ToString()!;
                AgregarPais.editarpais.Pais = dgvpaises.CurrentRow.Cells[1].Value.ToString()!;
            }
            agregarPais.ShowDialog();
        }

        private async void eliminarpais_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvpaises.SelectedRows.Count >= 0)
                {
                    var result = MessageBox.Show("¿Estás seguro de que quieres eliminar este país?", "Confirmación", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        bool eliminarpais = await paisController.DetelePais(dgvpaises.CurrentRow.Cells[0].Value.ToString()!,
                            dgvpaises.CurrentRow.Cells[1].Value.ToString()!);

                        if (eliminarpais)
                        {
                            await cargarDatos();
                            MessageBox.Show("Se eliminó el registro");
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar registro");
                        }
                    }
                }
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
            }
        }


        private async void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            var filtracionpais = await paisController.GetPaises();
            filtracionpais = filtracionpais.FindAll(pais => pais.IdPais.ToUpper().Contains(filtrarpais.Text.ToUpper())
            || pais.Pais.ToUpper().Contains(filtrarpais.Text.ToUpper()));
            dgvpaises.DataSource = filtracionpais;
        }
    }
}
