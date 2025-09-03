using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    public class DALJogo
    {
        private Conexao _conexao;

        // Construtor recebe a conexão (injeção de dependência simples)
        public DALJogo(Conexao conn)
        {
            this._conexao = conn;
        }

        public void Incluir(Jogo jogo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            cmd.CommandText = "INSERT INTO Jogos (Nome, Plataforma, Genero, AnoLancamento) " +
                              "VALUES (@nome, @plataforma, @genero, @ano)";
            cmd.Parameters.AddWithValue("@nome", jogo.Nome);
            cmd.Parameters.AddWithValue("@plataforma", jogo.Plataforma);
            cmd.Parameters.AddWithValue("@genero", jogo.Genero);
            cmd.Parameters.AddWithValue("@ano", jogo.AnoLancamento);

            _conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            _conexao.FecharConexao();
        }

        public void Alterar(Jogo jogo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            cmd.CommandText = "UPDATE Jogos SET Nome=@nome, Plataforma=@plataforma, Genero=@genero, AnoLancamento=@ano " +
                              "WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", jogo.Id);
            cmd.Parameters.AddWithValue("@nome", jogo.Nome);
            cmd.Parameters.AddWithValue("@plataforma", jogo.Plataforma);
            cmd.Parameters.AddWithValue("@genero", jogo.Genero);
            cmd.Parameters.AddWithValue("@ano", jogo.AnoLancamento);

            _conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            _conexao.FecharConexao();
        }

        public void Excluir(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            cmd.CommandText = "DELETE FROM Jogos WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);

            _conexao.AbrirConexao();
            cmd.ExecuteNonQuery();
            _conexao.FecharConexao();
        }

        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();

            // Busca simples pelo nome do jogo
            cmd.CommandText = @"
                SELECT Id, Nome, Plataforma, Genero, AnoLancamento
                FROM Jogos
                WHERE Nome LIKE @valor";

            cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            _conexao.FecharConexao();

            return tabela;
        }

        public Jogo CarregaModeloJogo(int id)
        {
            Jogo jogo = new Jogo();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conexao.ObterConexao();
            cmd.CommandText = "SELECT * FROM Jogos WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);

            _conexao.AbrirConexao();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                jogo.Id = Convert.ToInt32(registro["Id"]);
                jogo.Nome = Convert.ToString(registro["Nome"]);
                jogo.Plataforma = Convert.ToString(registro["Plataforma"]);
                jogo.Genero = Convert.ToString(registro["Genero"]);
                jogo.AnoLancamento = Convert.ToInt32(registro["AnoLancamento"]);
            }
            _conexao.FecharConexao();

            return jogo;
        }
    }
}