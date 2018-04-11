
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;
using System.Windows.Forms;


namespace RentCar_Project
{
    class Conexao
    {
        public string strCon = "Data Source=GUILHERME;Initial Catalog=PIMIII;Integrated Security=True;";
        public SqlConnection conectarBanco()
        {
           
            SqlConnection con = new SqlConnection(strCon);

            try
            {
                con.Open();
                MessageBox.Show("Banco de Dados conectado com sucesso!");
                return con;
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro de Conexão com o Banco de Dados! {0} Exception caught. " + e);
                return con;
            }

        }
        
    }
}
