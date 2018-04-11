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
    public partial class MotoristasPJ : Form
    {
        public MotoristasPJ()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CNPJ_Aut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CADASTRAR_MOTORISTAPJ", con);

            cmd.Parameters.AddWithValue("@NOME", txtNome_Aut.Text);
            cmd.Parameters.AddWithValue("@CNH", txtCNH_Aut.Text);
            cmd.Parameters.AddWithValue("@CNPJ", txtCNPJ_Aut.Text);

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

            listNome.Items.Add(txtNome_Aut.Text);
            listCNH.Items.Add(txtCNH_Aut.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome_Aut.Focus();
            txtNome_Aut.ResetText();
            txtCNH_Aut.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisarCondutores pesq = new PesquisarCondutores();
            pesq.MdiParent = this.MdiParent;
            pesq.Show();
        }
    }
}
