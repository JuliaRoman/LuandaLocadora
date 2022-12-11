using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraFilmes
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnTelaInicialLogin_Click(object sender, EventArgs e)
        {
            TelaInicial telainicial = new TelaInicial();
            telainicial.Show();
            Hide(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            if (campoSenhalogin.Text.Equals("") || campoCpfLogin.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos primeiro!");
            }
            else {
                TelaPrincipal telaprincipal = new TelaPrincipal();
                telaprincipal.Show();
                Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarLogin_Click(object sender, EventArgs e)
        {
            Image olho = new Bitmap(Properties.Resources.olho);
            Image olhoAberto = new Bitmap(Properties.Resources.olho_fechado);

            if (campoSenhalogin.UseSystemPasswordChar) {
                campoSenhalogin.UseSystemPasswordChar = false;
                btnVisualizarLogin.BackgroundImage = olhoAberto;
            } else {
                campoSenhalogin.UseSystemPasswordChar = true;
                btnVisualizarLogin.BackgroundImage = olho;
            }
        }
    }
}
