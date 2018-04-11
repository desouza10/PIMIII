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
    public partial class frm_CadastrarVeiculo : Form
    {
        public frm_CadastrarVeiculo()
        {
            InitializeComponent();
        }

        private void frm_CadastrarVeiculo_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conexao connect = new Conexao();

            string connectionString = connect.strCon;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("CADASTRAR_VEICULO", con);

            cmd.Parameters.AddWithValue("@PLACA_CAR", txtPlaca.Text);
            cmd.Parameters.AddWithValue("@MARCA", txtMarca.Text);
            cmd.Parameters.AddWithValue("@MODELO",txtModelo.Text);
            cmd.Parameters.AddWithValue("@ANO", txtAno.Text);
            cmd.Parameters.AddWithValue("@CAMBIO",txtCambio.Text);
            cmd.Parameters.AddWithValue("@MOTOR",txtMotor.Text);
            cmd.Parameters.AddWithValue("@AR_CONDICIONADO", comboAr.Text);
            cmd.Parameters.AddWithValue("@DIRECAO_HIDRAULICA", comboDirecao.Text);
            cmd.Parameters.AddWithValue("@COR",txtCor.Text);
            cmd.Parameters.AddWithValue("@RADIO_EMBUTIDO",comboRadio.Text);
            cmd.Parameters.AddWithValue("@VIDROS_ELETRICOS",comboVidro.Text);
            cmd.Parameters.AddWithValue("@PORTAS",comboPortas.Text);

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
