using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSeries.Enum;

namespace WebSeries.Entity
{
    public class Serie : EntityBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
    }
}
