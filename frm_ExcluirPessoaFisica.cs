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
    public partial class frm_ExcluirPessoaFísica : Form
    {
        public frm_ExcluirPessoaFísica()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETAR_CLIENTE", con);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text);
            
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados deletados com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Não foi possível deletar os dados de cadastro! {0} Exception caught. " + E, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private List<ClientePF> ObterListaCPF(string cpfCliente)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            List<ClientePF> lista = new List<ClientePF>();
            string query = "SELECT * FROM CLIENTE INNER JOIN ENDERECO ON CLIENTE.CEP_CLI=ENDERECO.CEP WHERE CPF LIKE '%" + cpfCliente + "%'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePF cli = new ClientePF();

                    cli.Id_Cliente = Convert.ToInt32(leitor["ID_Cliente"]);
                    cli.cpf = leitor["CPF"].ToString();
                    cli.nome = leitor["Nome"].ToString();
                    cli.cnh = leitor["CNH"].ToString();
                    cli.cep = leitor["CEP_Cli"].ToString();
                    cli.rg = leitor["RG"].ToString();
                    cli.orgaoEmissor = leitor["Orgao_Emissor"].ToString();
                    cli.dataEmissao = leitor["Data_Emissao"].ToString();
                    cli.telefone = leitor["Telefone"].ToString();
                    cli.email = leitor["Email"].ToString();
                    cli.Data_Nascimento = leitor["Data_Nasc"].ToString();
                    cli.logradouro = leitor["Rua"].ToString();
                    cli.bairro = leitor["Bairro"].ToString();
                    cli.cidade = leitor["Cidade"].ToString();
                    cli.complemento = leitor["Complemento"].ToString();
                    cli.uf = leitor["Sigla_Estado"].ToString();
                    cli.numero = Convert.ToInt32(leitor["Numero"].ToString());

                    lista.Add(cli);

                }
            }

            con.Close();

            return lista;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ObterListaCPF(txtPesquisar.Text);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);

            string query = "SELECT * FROM CLIENTE INNER JOIN ENDERECO ON CLIENTE.CEP_CLI=ENDERECO.CEP";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePF cli = new ClientePF();

                    txtNome.Text = leitor["Nome"].ToString();
                    txtCPF.Text = leitor["CPF"].ToString();
                    txtCNH.Text = leitor["CNH"].ToString();
                    txtCEP.Text = leitor["CEP_Cli"].ToString();
                    txtRG.Text = leitor["RG"].ToString();
                    comboOrgao.Text = leitor["Orgao_Emissor"].ToString();
                    mskDataEmissao.Text = leitor["Data_Emissao"].ToString();
                    mskTelefone.Text = leitor["Telefone"].ToString();
                    mskCelular.Text = leitor["Celular"].ToString();
                    mskOutroTel.Text = leitor["OutroTel"].ToString();
                    txtEmail.Text = leitor["Email"].ToString();
                    mskDataNasc.Text = leitor["Data_Nasc"].ToString();
                    txtLogradouro.Text = leitor["Rua"].ToString();
                    txtBairro.Text = leitor["Bairro"].ToString();
                    txtCidade.Text = leitor["Cidade"].ToString();
                    txtComplemento.Text = leitor["Complemento"].ToString();
                    comboUF.Text = leitor["Sigla_Estado"].ToString();
                    txtNumero.Text = leitor["Numero"].ToString();

                }
            }

            con.Close();
        }
    }
    
}
