using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ti45_08_08_2024
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            MenuPrincipal menuprincipal = new MenuPrincipal();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            var password = txtSenha.Text;

            if (nome == "admin" && password == "123")
            {

                MenuPrincipal menuprincipal = new MenuPrincipal();
                menuprincipal.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Usuário ou senha não confere, tente novamente");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {


            MenuPrincipal menuprincipal = new MenuPrincipal();
            this.Close();

        }
    }
}
