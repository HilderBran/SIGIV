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

namespace view.Empleados
{
    public partial class GestionEmpleados : Form
    {
        public GestionEmpleados()
        {
            InitializeComponent();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEmpleado agregarEmpleado = new AgregarEmpleado();
            var result = agregarEmpleado.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Empleado agregado", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await cargarEmpleados();
            }
        }
        private async Task cargarEmpleados()
        {
            try
            {
                var empleados = await MunicipioController.GetMunicipios();
                dgvEmpleados.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
