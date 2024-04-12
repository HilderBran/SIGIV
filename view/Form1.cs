using Models.Entities;

namespace view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Paise paise = new Paise();
            paise.IdPais = IdPais.Text;

            paise.Pais = Pais.Text;

            using(SigivContext context = new SigivContext())
            {
                context.Paises.Add(paise);

                context.SaveChanges();
            }
        }

      
    }
}
