using Controller;
using Models.Entities;

namespace view
{
    public partial class AgregarPais : Form
    {
        public static Paise editarpais { get; set; } = null!;
        private PaisController controller;

        public AgregarPais()
        {
            InitializeComponent();
            controller = new PaisController();
        }

        protected override void OnLoad(EventArgs e)
        {
            cargardatos();
            base.OnLoad(e);
        }

        private void cargardatos()
        {
            Guardar.Text = editarpais != null ? "Actualizar" : "Guardar";
            if (editarpais != null)
            {
                IdPais.Text = AgregarPais.editarpais.IdPais.ToString();
                Pais.Text = AgregarPais.editarpais.Pais.ToString();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            editarpais = null!;
            base.OnClosed(e);
        }
        private async void Guardar_Click(object sender, EventArgs e)
        {
            if (editarpais != null)
            {
                await Actualizarpais();
            }
            else
            {
                await agregarpais();
            }
        }

        private void cancelarpais_Click(object sender, EventArgs e)
        {
            IdPais.Text = string.Empty;
            Pais.Text = string.Empty;
            editarpais = null!;
            Close();
        }
        public async Task agregarpais()
        {
            try
            {
                var result = await controller.AddPais(IdPais.Text, Pais.Text);

                if (result)
                {
                    IdPais.Text = string.Empty;
                    Pais.Text = string.Empty;
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
        public async Task Actualizarpais()
        {
            try
            {
                var result = await controller.Actualizarpais(IdPais.Text, Pais.Text);

                if (result)
                {
                    MessageBox.Show("Se actualizo correctamente el pais");
                }
                else
                {
                    MessageBox.Show("Error al actualizar pais");
                }
            }
            catch (Exception ext)
            {
                MessageBox.Show(ext.Message);
            }
        }
    }
}
