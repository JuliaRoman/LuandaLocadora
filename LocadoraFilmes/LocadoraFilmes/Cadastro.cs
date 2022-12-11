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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTelaInicialCad_Click(object sender, EventArgs e)
        {
            TelaInicial telainicial = new TelaInicial();
            telainicial.Show();
            Hide();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCadastro_TextChanged(object sender, EventArgs e)
        {
            txtNomeCadastro.Text = "";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCadastro.Text.Equals("") || txtcpfCadastro.Text.Equals("") || camposenhacadastro.Text.Equals("") || campodatanasc.Text.Equals("") || camposenhadnvcadastro.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos primeiro!");
            }
            else
            {
                if (camposenhacadastro.Text.Equals(camposenhadnvcadastro.Text))
                {
                    TelaPrincipal telaprincipal = new TelaPrincipal();
                    telaprincipal.Show();
                    Hide();
                }
                else {
                    MessageBox.Show("Erro em confirmação de senha");
                    camposenhadnvcadastro.Text = "";
                }
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {
            Image olho = new Bitmap(Properties.Resources.olho);
            Image olhoAberto = new Bitmap(Properties.Resources.olho_fechado);

            if (camposenhacadastro.UseSystemPasswordChar)
            {
                camposenhacadastro.UseSystemPasswordChar = false;
                btnVisualizarSenha.BackgroundImage = olhoAberto;
            }
            else
            {
                camposenhacadastro.UseSystemPasswordChar = true;
                btnVisualizarSenha.BackgroundImage = olho;
            }
        }

        private void camposenhacadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVisualizarConfirm_Click(object sender, EventArgs e)
        {
            Image olho = new Bitmap(Properties.Resources.olho);
            Image olhoAberto = new Bitmap(Properties.Resources.olho_fechado);

            if (camposenhadnvcadastro.UseSystemPasswordChar)
            {
                camposenhadnvcadastro.UseSystemPasswordChar = false;
                btnVisualizarConfirm.BackgroundImage = olhoAberto;
            }
            else
            {
                camposenhadnvcadastro.UseSystemPasswordChar = true;
                btnVisualizarConfirm.BackgroundImage = olho;
            }
        }
    }
}


