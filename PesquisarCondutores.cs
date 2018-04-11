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
    public partial class PesquisarCondutores : Form
    {
        public PesquisarCondutores()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCondutores.DataSource = ObterListaCNH(txtPesquisarCNH.Text);
        }

        private List<ClientePJ> ObterListaCNH(string CnhCondutor)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            List<ClientePJ> lista = new List<ClientePJ>();
            string query = "SELECT ID_MOTORISTA, NOME, CNH, CNPJ FROM MOTORISTA_AUT WHERE CNH LIKE '%" + CnhCondutor + "%'";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePJ cli = new ClientePJ();

                    cli.ID_Motorista = Convert.ToInt32(leitor["ID_MOTORISTA"].ToString());
                    cli.motorista = leitor["NOME"].ToString();
                    cli.cnhMotorista = leitor["CNH"].ToString();
                    cli.cnpj = leitor["CNPJ"].ToString();
                    
                    lista.Add(cli);

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

            string query = "SELECT * FROM MOTORISTA_AUT";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            SqlDataReader leitor = cmd.ExecuteReader();

            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    ClientePF cli = new ClientePF();

                    txtNome.Text = leitor["Nome"].ToString();
                    txtCNPJ.Text = leitor["CNPJ"].ToString();
                    txtCNH.Text = leitor["CNH"].ToString();
                    txtNomeEx.Text = leitor["Nome"].ToString();
                    txtCNPJEx.Text = leitor["CNPJ"].ToString();
                    txtCNHEx.Text = leitor["CNH"].ToString();

                }
            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.ResetText();
            txtCNH.ResetText();
            txtCNPJ.ResetText();
            txtNomeEx.ResetText();
            txtCNHEx.ResetText();
            txtCNPJEx.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("ALTERAR_MOTORISTAPJ", con);

            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@CNH", txtCNH.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("DELETAR_MOTORISTAPJ", con);

            cmd.Parameters.AddWithValue("@NOME", txtNomeEx.Text);
            cmd.Parameters.AddWithValue("@CNH", txtCNHEx.Text);
            cmd.Parameters.AddWithValue("@CNPJ", txtCNPJEx.Text);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Dados deletados com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNome.ResetText();
                    txtCNH.ResetText();
                    txtCNPJ.ResetText();
                    txtNomeEx.ResetText();
                    txtCNHEx.ResetText();
                    txtCNPJEx.ResetText();
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
