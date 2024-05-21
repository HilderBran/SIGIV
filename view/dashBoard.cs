using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using view.Pais;

namespace view
{
    public partial class dashBoard : Form
    {
        private GestionPais gestionPais;

        public dashBoard(GestionPais gestionPais)
        {
            InitializeComponent();
            this.gestionPais = gestionPais;
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gestionPais.ShowDialog();
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Municipios.GestionMunicipios gestionMunicipios = new view.Municipios.GestionMunicipios();
            gestionMunicipios.ShowDialog();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Departamentos.GestionDepartamento gestionDepartamento = new view.Departamentos.GestionDepartamento();
            gestionDepartamento.ShowDialog();
        }

        private void distritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Distritos.GestionDistritos gestionDistritos = new view.Distritos.GestionDistritos();
            gestionDistritos.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view.Clientes.GestionClientes gestionClientes = new view.Clientes.GestionClientes();
            gestionClientes.ShowDialog();
        }
    }
}
