using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar_Project
{
    public partial class frm_PainelAtendente : Form
    {
        public frm_PainelAtendente()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
                
        private void pessoaFìsicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastrarClientePF cadastra = new frm_CadastrarClientePF();
            cadastra.MdiParent = this;
            cadastra.Show();
        }

        private void frm_PainelAtendente_Load(object sender, EventArgs e)
        {

        }

        private void alterarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AtualizarPessoaFisica atualizaPF = new frm_AtualizarPessoaFisica();
            atualizaPF.MdiParent = this;
            atualizaPF.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void excluirCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ExcluirPessoaFísica excluiPF = new frm_ExcluirPessoaFísica();
            excluiPF.MdiParent = this;
            excluiPF.Show(); 

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastrarClientePJ cadPJ = new CadastrarClientePJ();
            cadPJ.MdiParent = this;
            cadPJ.Show();
        }

        private void alterarCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_AtualizarPessoaJuridica attPJ = new frm_AtualizarPessoaJuridica();
            attPJ.MdiParent = this;
            attPJ.Show();
        }

        private void excluirCadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_CadastrarVeiculo cadV = new frm_CadastrarVeiculo();
            cadV.MdiParent = this;
            cadV.Show();
        }

        private void alterarVepiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AtualizarVeiculo atV = new frm_AtualizarVeiculo();
            atV.MdiParent = this;
            atV.Show();
        }

        private void excluirVeículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ExcluirVeiculo exV = new Frm_ExcluirVeiculo();
            exV.MdiParent = this;
            exV.Show();
        }
    }
}
