using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//namespace 

namespace LearnCode.PontoAprendizagem// definicao namespace
{
    public class DatabaseConnection// criacao da classe
    {
        private SqlConnection connection;

        public DatabaseConnection()
        {

            string connectionstring = "Server=DESKTOP-56K4DVJ;Database=LearnCodeTest;Integrated Security=True;";
            this.connection = new SqlConnection(connectionstring);//objeto instancia
        }

        public void Open()// metodo (void)
        {
            this.connection.Open();
        }
        
        public void Close() 
        { 
            this.connection.Close(); 
        }
        
        public SqlConnection GetConnection()// metodo (SqlConnection) - retornar conecxao SQL
        {
            return this.connection;
        }
    
    
    
    }

}
