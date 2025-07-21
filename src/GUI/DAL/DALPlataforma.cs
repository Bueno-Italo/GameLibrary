using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DAL;
using System.Data;
using GUI.BLL;

namespace GUI.DAL
{
    // Esta classe realiza as operações de banco para a entidade Plataforma
    public class DALPlataforma
    {
        private Conexao _conexao;

        // Construtor recebe a conexão (injeção de dependência simples)
        public DALPlataforma(Conexao conn)
        {
            this._conexao = conn;
        }

        // Método para inserir uma nova plataforma no banco
        public void Inserir(Plataforma modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            cmd.CommandText = "INSERT INTO Plataforma (Nome) VALUES (@nome)";
            cmd.Parameters.AddWithValue("@nome", modelo.Nome);

            _conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            _conexao.FecharConexao();
        }

        public DataTable ListarTodas()
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            //_conexao.AbrirConexao();
            cmd.CommandText = "SELECT * FROM plataforma";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            _conexao.FecharConexao();
            return tabela;
        }
    }
}
