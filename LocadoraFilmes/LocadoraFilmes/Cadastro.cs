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
            TelaPrincipal telaprincipal = new TelaPrincipal();
            telaprincipal.Show();
            Hide();
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
    }
}
