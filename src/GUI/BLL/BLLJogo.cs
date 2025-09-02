using GUI.DAL;
using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.BLL
{
    public class BLLJogo
    {
        private Conexao _conexao;

        public BLLJogo(Conexao conn)
        {
            _conexao = conn;
        }

        public void Inserir(Jogo jogo)
        {
            if (string.IsNullOrWhiteSpace(jogo.Nome))
                throw new Exception("O nome do jogo é obrigatório.");

            DALJogo dal = new DALJogo(_conexao);
            dal.Incluir(jogo);
        }

        public void Alterar(Jogo jogo)
        {
            if (jogo.Id <= 0)
                throw new Exception("O ID do jogo é obrigatório para alteração.");

            DALJogo dal = new DALJogo(_conexao);
            dal.Alterar(jogo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O ID do jogo é obrigatório para exclusão.");

            DALJogo dal = new DALJogo(_conexao);
            dal.Excluir(id);
        }

        public DataTable Localizar(string valor)
        {
            DALJogo dal = new DALJogo(_conexao);
            return dal.Localizar(valor);
        }

        public Jogo CarregaModeloJogo(int id)
        {
            DALJogo dal = new DALJogo(_conexao);
            return dal.CarregaModeloJogo(id);
        }
    }
}

