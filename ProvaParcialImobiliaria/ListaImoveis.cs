using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaParcialImobiliaria
{
    public partial class ListaImoveis : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AnaDosSantos\source\repos\ProvaParcialImobiliaria\Database\Data.mdf;Integrated Security=True");
        SqlCommand myStmt;
        SqlDataReader myRs;
        public ListaImoveis()
        {
            InitializeComponent();
        }

        private void ListaImoveis_Load(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
            }
            catch (Exception)
            {
                throw;
            }

            String cmd_sql;
            cmd_sql = "SELECT ID, NOMEPROPRIETARIO, ENDERECO, VALOR, DATAINICIAL, FOTO FROM IMOVEISBD";
            myStmt = new SqlCommand(cmd_sql, myConn);
            myRs = myStmt.ExecuteReader();


            if (myRs.HasRows)
            {
                listImoveis.Items.Clear();
                while (myRs.Read())
                {
                    listImoveis.Items.Add("Id: " + myRs["id"] + "Nome: " + myRs["nomeproprietario"].ToString() + " - " + "Endereco: " + myRs["endereco"].ToString() + " - " + "Valor: " + myRs["valor"].ToString() + " - " + "Data:" + myRs["datainicial"].ToString() + " - " + "Foto: " + myRs["foto"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Registro Não Localizado", "Consulta - Aluno");
            }

            myRs.Close();
            myStmt.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
