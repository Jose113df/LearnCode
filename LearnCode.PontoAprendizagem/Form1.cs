using System.Data.Common;
using System.Data.SqlClient;

namespace LearnCode.PontoAprendizagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection= new DatabaseConnection();
            dbConnection.Open();

           MessageBox.Show (dbConnection.GetConnection().ToString());
            
            dbConnection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Open();//abrindo

            //comandos SQL
            SqlCommand comando =dbConnection.GetConnection().CreateCommand();// peguei a conexão
           
            // recurcso do bando mais basico ao mais avançado
            // o que escolhemos é um baasico(comando de texto)           
            comando.CommandType = System.Data.CommandType.Text;

            //definindo a DMl (Data Manipulation Language)
            comando.CommandText = "insert into Aula(Descricao,Esboco)values(@Descricao,@Esboco)";
            
            //Passando valor para parâmetros
            comando.Parameters.Add(new SqlParameter("@Descricao", textBox1.Text));
            comando.Parameters.Add(new SqlParameter("@Esboco", textBox2.Text));
            
            //executar o DML (INSERT INTO...)
            comando.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            dbConnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            dbConnection.Open();
            SqlCommand comando = dbConnection.GetConnection().CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            
            MessageBox.Show( comando.CommandText = ("select* from Aluno"));

            dbConnection.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}