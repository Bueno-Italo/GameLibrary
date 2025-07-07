using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    //Classe que representa a entidade plataforma do sistema
    public class Plataforma
    {
        //Propriedade para armazenar Id da plataforma (FK no DB)
        public int Id { get; set; }

        //Armazena as plataformas ex: PS3,PS4...
        public string Nome { get; set; }
    }
}