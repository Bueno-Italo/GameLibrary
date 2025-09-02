using GUI.DAL;
using GUI.Modelo;
using GUI.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.BLL
{
    // Esta classe representa as regras de negócio para Plataforma
    public class BLLPlataforma
    {
        private Conexao _conexao;

        // Construtor recebe a conexão
        public BLLPlataforma(Conexao conn)
        {
            _conexao = conn;
        }

        // Método que valida e repassa o modelo para a DAL
        public void Inserir(Plataforma modelo)
        {
            // Verifica se o nome está em branco
            if (string.IsNullOrWhiteSpace(modelo.Nome))
            {
                throw new Exception("O nome da plataforma é obrigatório.");
            }

            // Cria objeto da DAL e chama o método de inserir
            DALPlataforma dal = new DALPlataforma(_conexao);
            dal.Inserir(modelo);
        }

        public DataTable ListarTodas()
        {
            DALPlataforma dal = new DALPlataforma(_conexao);
            return dal.ListarTodas();
        }

        public void Alterar(Plataforma modelo)
        {
            if (modelo.Id <= 0)
                throw new Exception("ID inválido para alteração.");

            if (string.IsNullOrWhiteSpace(modelo.Nome))
                throw new Exception("O nome da plataforma é obrigatório.");

            DALPlataforma dal = new DALPlataforma(_conexao);
            dal.Alterar(modelo);
        }

        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("ID inválido para exclusão.");

            DALPlataforma dal = new DALPlataforma(_conexao);
            dal.Excluir(id);
        }

        public DataTable PesquisarPorNome(string nome)
        {
            DALPlataforma dal = new DALPlataforma(_conexao);
            return dal.PesquisarPorNome(nome);
        }

    }
}
