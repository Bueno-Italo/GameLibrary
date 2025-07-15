using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.DAL;

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
    }
}
