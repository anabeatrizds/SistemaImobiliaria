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
    public partial class ConsultarImovel : Form
    {
        SqlConnection myConn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\AnaDosSantos\source\repos\ProvaParcialImobiliaria\Database\Data.mdf;Integrated Security=True");
        SqlCommand myStmt;
        SqlDataReader myRs;

        public ConsultarImovel()
        {
            InitializeComponent();
        }

        private void ConsultarImovel_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            String cmd_sql;
            var where = "";

            if (!string.IsNullOrEmpty(txtNome.Text)) where += "and nomeproprietario = '" + txtNome.Text + "'";

            if (!string.IsNullOrEmpty(txtEnd.Text)) where += "and endereco = '" + txtEnd.Text + "'";

            if (!string.IsNullOrEmpty(txtValor.Text)) where += "and valor = '" + txtValor.Text + "'";

            if (!string.IsNullOrEmpty(inputDate.Text)) where += "and datainicial = '" + inputDate.Text + "'";

            if (!string.IsNullOrEmpty(txtFoto.Text)) where += "and foto = '" + txtFoto.Text + "'";

            cmd_sql = "SELECT * FROM IMOVEISBD WHERE id > 0 " + where;
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

        private void Limpar()
        {
            txtNome.Text = "";
            txtEnd.Text = "";
            txtValor.Text = "";
            txtFoto.Text = "";
            inputDate.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int retorno;
            String cmd_sql;

            cmd_sql = "DELETE IMOVEISBD WHERE ID = " + txtId.Text;
            myStmt = new SqlCommand(cmd_sql, myConn);
            retorno = myStmt.ExecuteNonQuery();

            if (retorno > 0)
            {
                MessageBox.Show("Excluido com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Algo deu errado. Não foi possível excluir! Exclusão é feita somente pelo Id.");
            }
        }
    }
}
