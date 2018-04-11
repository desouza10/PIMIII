using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DirectShowLib;
using AForge.Video;
using AForge.Video.DirectShow;

using System.Data.SqlClient;

namespace RentCar_Project
{
    public partial class frm_CadastrarClientePF : Form
    {

        

        public frm_CadastrarClientePF()
        {
            InitializeComponent();
            

        }

        private void frm_CadastrarClientePF_Load(object sender, EventArgs e)
        {
            
        }

        
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CADASTRAR_CLIENTE", con);
            cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
            cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
            cmd.Parameters.AddWithValue("@CNH", txtCNH.Text);
            cmd.Parameters.AddWithValue("@RG", txtRG.Text);
            cmd.Parameters.AddWithValue("@ORGAO_EMISSOR", comboOrgao.Text);
            cmd.Parameters.AddWithValue("@DATA_EMISSAO", mskDataEmissao.Text);
            cmd.Parameters.AddWithValue("@TELEFONE", mskTelefone.Text);
            cmd.Parameters.AddWithValue("@CELULAR", mskCelular.Text);
            cmd.Parameters.AddWithValue("@OUTROTEL", mskOutroTel.Text);
            cmd.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            cmd.Parameters.AddWithValue("@CLI_STATUS", CheckState.Checked);
            cmd.Parameters.AddWithValue("@DATA_NASC", mskDataNasc.Text);
            cmd.Parameters.AddWithValue("@CEP", txtCEP.Text);
            cmd.Parameters.AddWithValue("@CEP_CLI", txtCEP.Text);
            cmd.Parameters.AddWithValue("@RUA", txtLogradouro.Text);
            cmd.Parameters.AddWithValue("@NUMERO", txtNumero.Text);
            cmd.Parameters.AddWithValue("@COMPLEMENTO", txtComplemento.Text);
            cmd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
            cmd.Parameters.AddWithValue("@SIGLA", comboUF.Text);
            cmd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtBairro.ResetText();
            txtCEP.ResetText();
            txtCidade.ResetText();
            txtCNH.ResetText();
            txtComplemento.ResetText();
            txtCPF.ResetText();
            txtEmail.ResetText();
            txtLogradouro.ResetText();
            txtNome.ResetText();
            txtNumero.ResetText();
            txtRG.ResetText();
            mskCelular.ResetText();
            mskDataEmissao.ResetText();
            mskDataNasc.ResetText();
            mskOutroTel.ResetText();
            mskTelefone.ResetText();
            comboOrgao.ResetText();
            comboUF.ResetText();
        }
    }
}
