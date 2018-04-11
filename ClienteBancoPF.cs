using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace RentCar_Project
{
    class ClienteBancoPF : Cliente
    {

        frm_CadastrarClientePF cliPF = new frm_CadastrarClientePF();

        public void cadastrarCliente()
        {
           // string sql = "INSERT INTO CLIENTE (NOME, CPF, CNH, RG, ORGAO_EMISSOR, DATA_EMISSAO, TELEFONE, EMAIL, CLI_STATUS, DATA_NASC)" +
           //   "VALUES (@NOME, @CPF, @CNH, @RG, @ORGAO_EMISSOR, @DATA_EMISSAO, @TELEFONE, @EMAIL, @CLI_STATUS, @DATA_NASC);";

            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);            
            SqlCommand cmd = new SqlCommand("CADASTRAR_CLIENTE", con);
            cmd.Parameters.AddWithValue("@NOME", cliPF.txtNome.Text);
            cmd.Parameters.AddWithValue("@CPF", cliPF.txtCPF.Text);
            cmd.Parameters.AddWithValue("@CNH", cliPF.txtCNH.Text);
            cmd.Parameters.AddWithValue("@RG", cliPF.txtRG.Text);
            cmd.Parameters.AddWithValue("@ORGAO_EMISSOR", cliPF.comboOrgao.Text);
            cmd.Parameters.AddWithValue("@DATA_EMISSAO", cliPF.mskTelefone.Text);
            cmd.Parameters.AddWithValue("@TELEFONE", cliPF.mskTelefone.Text);
            cmd.Parameters.AddWithValue("@EMAIL", cliPF.txtEmail.Text);
            cmd.Parameters.AddWithValue("@CLI_STATUS", CheckState.Checked);
            cmd.Parameters.AddWithValue("@DATA_NASC", cliPF.mskDataNasc.Text);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }catch(Exception E)
            {
                MessageBox.Show("Não foi possível realizar o cadastro! {0} Exception caught. " + E, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }
    }
}
