using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RentCar_Project
{
    public partial class frm_AtualizarVeiculo : Form
    {
        public frm_AtualizarVeiculo()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgvVeiculos.DataSource = ObterListaVeiculo(txtPesquisaPlaca.Text);
        }

        private List<Veiculo> ObterListaVeiculo(string placa)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            List<Veiculo> lista = new List<Veiculo>();
            string query = "SELECT * FROM VEICULO WHERE PLACA_CAR LIKE '%" + placa + "%'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    Veiculo v = new Veiculo();

                    v.Placa = leitor["Placa_Car"].ToString();
                    v.Marca = leitor["Marca"].ToString();
                    v.Modelo = leitor["Modelo"].ToString();
                    v.Ano = leitor["Ano"].ToString();
                    v.Cambio = leitor["Cambio"].ToString();
                    v.Motor = Convert.ToInt32(leitor["Motor"].ToString());
                    v.ArCondicionado = leitor["Ar_Condicionado"].ToString();
                    v.DirecaoHidraulica = leitor["Direcao_hidraulica"].ToString();
                    v.Cor = leitor["Cor"].ToString();
                    v.RadioEmbutido = leitor["Radio_Embutido"].ToString();
                    v.VidrosEletricos = leitor["Vidros_Eletricos"].ToString();
                    v.Portas = leitor["Portas"].ToString();

                    lista.Add(v);

                }
            }

            con.Close();

            return lista;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT * FROM VEICULO";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePF cli = new ClientePF();

                    txtPlaca.Text = leitor["Placa_Car"].ToString();
                    txtMarca.Text = leitor["Marca"].ToString();
                    txtModelo.Text = leitor["Modelo"].ToString();
                    txtAno.Text = leitor["Ano"].ToString();
                    txtCambio.Text = leitor["Cambio"].ToString();
                    txtMotor.Text = leitor["Motor"].ToString();
                    comboAr.Text = leitor["Ar_Condicionado"].ToString();
                    comboDirecao.Text = leitor["Direcao_hidraulica"].ToString();
                    txtCor.Text = leitor["Cor"].ToString();
                    comboRadio.Text = leitor["Radio_Embutido"].ToString();
                    comboVidro.Text = leitor["Vidros_Eletricos"].ToString();
                    comboPortas.Text = leitor["Portas"].ToString();

                }
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("ALTERAR_VEICULO", con);

            cmd.Parameters.AddWithValue("@PLACA_CAR", txtPlaca.Text);
            cmd.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            cmd.Parameters.AddWithValue("@MODELO", txtModelo.Text);
            cmd.Parameters.AddWithValue("@ANO", txtAno.Text);
            cmd.Parameters.AddWithValue("@CAMBIO", txtCambio.Text);
            cmd.Parameters.AddWithValue("@MOTOR", txtMotor.Text);
            cmd.Parameters.AddWithValue("@AR_CONDICIONADO", comboAr.Text);
            cmd.Parameters.AddWithValue("@DIRECAO_HIDRAULICA", comboDirecao.Text);
            cmd.Parameters.AddWithValue("@COR", txtCor.Text);
            cmd.Parameters.AddWithValue("@RADIO_EMBUTIDO", comboRadio.Text);
            cmd.Parameters.AddWithValue("@VIDROS_ELETRICOS", comboVidro.Text);
            cmd.Parameters.AddWithValue("@PORTAS", comboPortas.Text);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Informações atualizadas com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Não foi possível alterar os dados de cadastro! {0} Exception caught. " + E, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }

        }
    }
    
}
