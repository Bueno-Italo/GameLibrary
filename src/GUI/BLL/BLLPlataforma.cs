using GUI.DAL;
using GUI.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
