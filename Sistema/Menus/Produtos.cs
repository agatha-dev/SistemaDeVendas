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

namespace Sistema
{
    public partial class frm_Produtos : Form
    {
        public frm_Produtos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Produtos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Definimos a string de conexão

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-OSM46QI;Initial Catalog=db_Sistema;Integrated Security=True");

            //cria string de inserção sql
            string sql = "INSERT INTO produto(id_produto, desc_produto, valor, id_categoria) VALUES (@id_produto, @desc_produto, @valor, @id_categoria)";
            Random numero = new Random();
            numero.Next();

            try
            {
               //cria um obj do tipo comando passando como parametro a stringsql  conn
               SqlCommand sqlCommand = new SqlCommand(sql, conn);

                //Insere os dados da textbox no comando sql
                sqlCommand.Parameters.Add(new SqlParameter("@id_produto",numero.Next()));
                sqlCommand.Parameters.Add(new SqlParameter("@desc_produto", this.txt_descricao.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@valor", this.txt_valor.Text));
                sqlCommand.Parameters.Add(new SqlParameter("@id_categoria", numero.Next()));

                //abrimos a conexão com banco de dados
                conn.Open();
                //Executa o comando no banco de dados
                sqlCommand.ExecuteNonQuery();

                //Fechar a conexão 
                conn.Close();

                //Avisando o usurio
                MessageBox.Show("Enviado com sucesso!");

            } catch(SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //SqlCommand cmd = new SqlCommand();
            //ShowDialog
        }
    }
}
