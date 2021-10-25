using ProvaParcialImobiliaria.Model;
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
    public partial class CadastrarImovel : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AnaDosSantos\source\repos\ProvaParcialImobiliaria\Database\Data.mdf;Integrated Security=True");
        SqlCommand myStmt;

        public CadastrarImovel()
        {
            InitializeComponent(); 
        }

        private void CadastrarImovel_Load(object sender, EventArgs e)
        {
            try
            {
                myConn.Open();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            {
                string sql;
                int retorno;
                sql = "INSERT INTO IMOVEISBD (NOMEPROPRIETARIO, ENDERECO, VALOR, DATAINICIAL, FOTO) VALUES ('" + txtNome.Text + "' , '" + txtEnd.Text + "' , '" + txtValor.Text + "' , '" + txtDate.Text + "' , '" + txtFoto.Text + "')";
                myStmt = new SqlCommand(sql, myConn);
                    retorno = myStmt.ExecuteNonQuery();
                    if (retorno > 0)
                    {
                        MessageBox.Show("Cadastro efetuado");
                    }
                    else
                    {
                        MessageBox.Show("Cadastro não realizado");
                    }
            }
        }
    }
}