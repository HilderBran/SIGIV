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

namespace view.Opciones
{
    public partial class GestionOpciones : Form
    {
        private OpcionController opcionSeleccionada = null!;
        public GestionOpciones()
        {
            InitializeComponent();
            this.txbNombre.TextChanged += TxbNombre_TextChanged;
            this.lstbOpciones.SelectedValueChanged += LstbOpciones_SelectedValueChanged;
        }

        private void LstbOpciones_SelectedValueChanged(object? sender, EventArgs e)
        {
            try
            {
                if (this.rbEliminar.Checked || this.rbModificar.Checked)
                {
                    opcionSeleccionada = (OpcionController)this.lstbOpciones.SelectedItem!;
                    this.txbNombre.Text = opcionSeleccionada.Nombre;
                }

                if (this.rbBuscar.Checked || this.rbNuevo.Checked)
                {
                    this.txbNombre.Text = string.Empty;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TxbNombre_TextChanged(object? sender, EventArgs e)
        { 
            try
            {
                if (this.rbBuscar.Checked && this.txbNombre.Text != string.Empty)
                {
                    var opciones = (List<OpcionController>)this.lstbOpciones.DataSource!;

                    opciones = opciones.Where(opcion => opcion.Nombre.ToLower().Contains(this.txbNombre.Text.ToLower()))
                            .ToList();

                    this.lstbOpciones.DataSource = opciones;
                }

                if (this.txbNombre.Text == string.Empty && this.rbBuscar.Checked) await Cargar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        protected override async void OnLoad(EventArgs e)
        {
            try
            {
                await Cargar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            base.OnLoad(e);
        }

        private async Task Cargar()
        {
            var opciones = await OpcionController.GetAsync();
            this.lstbOpciones.DataSource = opciones;
            this.lstbOpciones.ValueMember = "Id";
            this.lstbOpciones.DisplayMember = "Nombre";
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.rbNuevo.Checked)
                    await Guardar();
                if (this.rbModificar.Checked)
                    await Modificar();
                if (this.rbEliminar.Checked)
                    await Eliminar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task Eliminar()
        {
            if (this.opcionSeleccionada == null) throw new Exception("Selecciona un opcion antes de ejecutar");


            if(MessageBox.Show("¿Estás seguro de que quieres eliminar este país?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool result = await this.opcionSeleccionada.DeleteAsync();

                if (!result) throw new Exception("Ocurrio un problema interno, porfavor intentalo mas tarde");
                this.txbNombre.Text = string.Empty;
                this.rbBuscar.Checked = true;
                await Cargar();
            } 
        }

        private async Task Modificar()
        {
            if (this.opcionSeleccionada == null) throw new Exception("Selecciona un opcion antes de ejecutar");
            this.opcionSeleccionada.Nombre = this.txbNombre.Text;
            
            bool result = await this.opcionSeleccionada.UpdateAsync();

            if (!result) throw new Exception("Ocurrio un problema interno, porfavor intentalo mas tarde");
            this.txbNombre.Text = string.Empty;
            this.rbBuscar.Checked = true;
            await Cargar();

        }

        private async Task Guardar()
        {
            var opcion = new OpcionController
            {
                Nombre = this.txbNombre.Text,
            };

            bool result = await opcion.SaveAsync();

            if (!result) throw new Exception("Ocurrio un problema interno, porfavor intentalo mas tarde");
            this.txbNombre.Text = string.Empty;
            this.rbBuscar.Checked = true;
            await Cargar();
        }
    }
}
