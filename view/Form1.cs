using Controller;

namespace view
{
    public partial class Form1 : Form
    {
        private PaisController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new PaisController();
        }


        private async void Guardar_Click(object sender, EventArgs e)
        {
            try
            {

                var result = await controller.AddPais(IdPais.Text, Pais.Text);

                if (result)
                {
                    MessageBox.Show("Se registro correctamente el pais");
                }
                else
                {
                    MessageBox.Show("Error al registrar pais");
                }
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
                
            }
           
        }

      
    }
}
