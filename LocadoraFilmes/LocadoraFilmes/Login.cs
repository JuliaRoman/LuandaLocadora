using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LocadoraFilmes
{
    public partial class Login : Form
    {
        private MySqlConnection conexaobd;
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
                try
                {
                    string data_source = "datasource=localhost;username=root;password=;database=locadora";

                    //CRIANDO A CONEXÂO MYSQL

                    conexaobd = new MySqlConnection(data_source);

                    MySqlCommand comando = new MySqlCommand();
                    comando.CommandText = "SELECT senha FROM contas_cli WHERE cpf=@cpf And senha=@senha";
                    comando.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = campoCpfLogin.Text;
                    comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = campoSenhalogin.Text;
                    comando.CommandType = CommandType.Text;
                    comando.Connection = conexaobd;

                    conexaobd.Open();

                    MySqlDataReader reader = comando.ExecuteReader();
                    if (reader.HasRows)
                    {
                        //usuario logado
                        MessageBox.Show("Login realizado com sucesso");

                        TelaPrincipal telaprincipal = new TelaPrincipal();
                        telaprincipal.Show();
                        Hide();
                    }
                    else
                    {
                        //todo : Login ou Senha Invalida
                        MessageBox.Show("Login ou senha inválida!");
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    conexaobd.Close();
                }
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
