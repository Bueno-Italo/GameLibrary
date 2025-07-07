using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Conexao
    {
        //Objeto de conexão DB
        private SqlConnection conexao;

        //Construtor da classe: define a string e instancia o objeto SqlConnection
        public Conexao()
        {
           // conexao = new SqlConnection(@"Data Source=DESKTOP-UIOFKUL\SQLEXPRESS;Initial Catalog=GameLibraryDB;Integrated Security=True");
            conexao = new SqlConnection("Data Source=DESKTOP-UIOFKUL\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True;TrustServerCertificate=True;");
            //"Data Source=DESKTOP-UIOFKUL\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True;TrustServerCertificate=True;"
        }

        //Método que abre a conexão
        public void AbrirConexao()
        {
            conexao.Open();
        }

        public void FechaConexao()
        {
            conexao.Close();
        }

        //Retorna o objeto da conexão
        public SqlConnection ObterConexao()
        {
            return conexao;
        }
    }
}
