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
    public partial class frm_AtualizarPessoaJuridica : Form
    {
        public frm_AtualizarPessoaJuridica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("ALTERAR_CLIENTEPJ", con);

            cmd.Parameters.AddWithValue("@RAZAO_SOCIAL", txtRazao.Text);
            cmd.Parameters.AddWithValue("@CNPJ", txtCNPJ.Text);
            cmd.Parameters.AddWithValue("@REPRESENTANTE", txtRepresentante.Text);
            cmd.Parameters.AddWithValue("@IE", txtIE.Text);
            cmd.Parameters.AddWithValue("@CLIPJ_STATUS", CheckState.Checked);
            cmd.Parameters.AddWithValue("@TELEFONE", mskTelefone.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@CEP_CLIPJ", txtCEP.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text);
            cmd.Parameters.AddWithValue("@RUA", txtLogradouro.Text);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
            cmd.Parameters.AddWithValue("@SIGLA", comboUF.Text);
            cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
            cmd.Parameters.AddWithValue("@NUMERO", txtNumero.Text);

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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dgvClientesPesq.DataSource = ObterListaCNPJ(txtPesquisarCNH.Text);
        }

        private List<ClientePJ> ObterListaCNPJ(string CNPJ)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            List<ClientePJ> lista = new List<ClientePJ>();
            string query = "SELECT * FROM CLIENTE_PJ INNER JOIN ENDERECO ON CLIENTE_PJ.CEP_CLIPJ=ENDERECO.CEP WHERE CNPJ LIKE '%" + CNPJ + "%'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePJ cli = new ClientePJ();

                    cli.cnpj = leitor["CNPJ"].ToString();
                    cli.razaoSocial = leitor["RAZAO_SOCIAL"].ToString();
                    cli.representante = leitor["REPRESENTANTE"].ToString();
                    cli.inscricaoEstadual = leitor["IE"].ToString();
                    cli.telefone = leitor["TELEFONE"].ToString();
                    cli.email = leitor["EMAIL"].ToString();
                    cli.cep = leitor["CEP_CLIPJ"].ToString();
                    cli.cep = leitor["CEP"].ToString();
                    cli.logradouro = leitor["RUA"].ToString();
                    cli.complemento = leitor["COMPLEMENTO"].ToString();
                    cli.cidade = leitor["CIDADE"].ToString();
                    cli.uf = leitor["SIGLA_ESTADO"].ToString();
                    cli.bairro = leitor["BAIRRO"].ToString();
                    cli.numero = Convert.ToInt32(leitor["NUMERO"].ToString());

                    lista.Add(cli);

                }
            }

            con.Close();

            return lista;
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTransferir_Click_1(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT * FROM CLIENTE_PJ INNER JOIN ENDERECO ON CLIENTE_PJ.CEP_CLIPJ=ENDERECO.CEP";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePF cli = new ClientePF();

                    txtRazao.Text = leitor["RAZAO_SOCIAL"].ToString();
                    txtCNPJ.Text = leitor["CNPJ"].ToString();
                    txtRepresentante.Text = leitor["REPRESENTANTE"].ToString();
                    txtIE.Text = leitor["IE"].ToString();
                    mskTelefone.Text = leitor["TELEFONE"].ToString();
                    txtEmail.Text = leitor["EMAIL"].ToString();
                    txtCEP.Text = leitor["CEP_CLIPJ"].ToString();
                    txtLogradouro.Text = leitor["RUA"].ToString();
                    txtComplemento.Text = leitor["COMPLEMENTO"].ToString();
                    txtCidade.Text = leitor["CIDADE"].ToString();
                    comboUF.Text = leitor["SIGLA_ESTADO"].ToString();
                    txtBairro.Text = leitor["BAIRRO"].ToString();
                    txtNumero.Text = leitor["NUMERO"].ToString();

                }
            }

            con.Close();
        }

    }
}
