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

namespace view
{
    public partial class Login : Form
    {
        private readonly LoginController controller;
        private dashBoard dashBoard;
        public Login(LoginController controller, dashBoard dashBoard) {
            InitializeComponent();
            this.controller = controller;
            this.dashBoard = dashBoard;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e) {
            try {
                // await controller.Loggin(txtUsuario.Text, txtContraseña.Text
                if (true) {
                    this.Hide();
                    this.dashBoard.ShowDialog(); 
                }
            }
            catch (Exception exc) {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
