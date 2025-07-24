using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    // Classe responsável por abrir e fechar conexão com o banco
    public class Conexao
    {
        private SqlConnection _conexao;

        // Construtor: define a string de conexão ao banco
        public Conexao()
        {
            // Ajuste essa string com o nome do seu servidor e banco
            _conexao = new SqlConnection(@"Data Source=DESKTOP-UIOFKUL\SQLEXPRESS;Initial Catalog=GameLibrary;Integrated Security=True;TrustServerCertificate=True;");
        }

        // Método que retorna a instância da conexão
        public SqlConnection ObterConexao()
        {
            return _conexao;
        }

        // Método para abrir a conexão
        public void AbrirConexao()
        {
            if (_conexao.State == System.Data.ConnectionState.Closed)
            {
                _conexao.Open();
            }
        }

        // Método para fechar a conexão
        public void FecharConexao()
        {
            if (_conexao.State == System.Data.ConnectionState.Open)
            {
                _conexao.Close();
            }
        }
    }
}
