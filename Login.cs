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

namespace RentCar_Project.Login
{
    public partial class frm_Login : Form
    {
        Conexao conexao = new Conexao();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAtend.Text == "")
            {
                MessageBox.Show("Digite o seu usuário Atendente!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else

                if (txtsenAten.Text == "")
                {
                    MessageBox.Show("Digite a senha do atendente!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            else
            {
                MessageBox.Show("Acesso ao Sistema!", "Acesso Autorizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_PainelAtendente Atendente = new frm_PainelAtendente();
                Atendente.ShowDialog();
                this.Close();
            }
                   
        }

        private void btn_teste_Click(object sender, EventArgs e)
        {
            conexao.conectarBanco();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
