using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//namespace GameLibrary.Modelo
namespace GUI.Modelo
{
    public class Plataforma
    {
        // Identificador único no banco de dados
        public int Id { get; set; }

        // Nome da plataforma (ex: "Playstation 3", "Steam")
        public string Nome { get; set; }
    }
}
