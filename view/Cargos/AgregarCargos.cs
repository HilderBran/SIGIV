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

namespace view.Cargos
{
    public partial class AgregarCargos : Form
    {
        public CargoController cargo;
        public AgregarCargos(CargoController cargo = null!)
        {
            InitializeComponent();
            this.cargo = cargo;
        }

        private void AgregarCargos_Load(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cargo == null)
            {
                await GuardarCargo();
            }
            else
            {
                await ActualizarCargo();
            }
        }

        private async Task ActualizarCargo()
        {
            try
            {
                cargo.Nombre = txbCargo.Text;
                bool bandera = await cargo.UpdateCargo();

                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cargo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task GuardarCargo()
        {
            try
            {
                CargoController cargo = new CargoController();
                cargo.Nombre = txbCargo.Text;
                bool bandera = await cargo.AddCargo();


                if (bandera)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el cargo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
