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
    public partial class CadastrarClientePJ : Form
    {
        public CadastrarClientePJ()
        {
            InitializeComponent();
        }

        private void CadastrarClientePJ_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_PainelAtendente painel = new frm_PainelAtendente();
            MotoristasPJ motorista = new MotoristasPJ();
            motorista.MdiParent = this.MdiParent;
            motorista.Show();

            motorista.txtCNPJ_Aut.Text = txtCNPJ.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CADASTRAR_CLIENTE_PJ", con);

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
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception E)
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
