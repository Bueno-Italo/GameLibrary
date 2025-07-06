using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Moledo
{
    // Classe representa a entidade Plataforma no sistema.
    public class Plataforma
    {
        // Propriedade que armazena o ID da plataforma(chave primária no banco de dados).
        public int ID { get; set; }
        // Propriedade que armazena o nome da plataforma, como "PlayStation 5", "PC", etc
        public string Nome { get; set; }

        public int ID2 { get; set; } //Teste teste02
    }
}
