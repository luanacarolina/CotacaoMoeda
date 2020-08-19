using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace atlas_moeda.Models
{
    public class Moeda
    {
        public int Id { get; set; }
        public string Sigla { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
    }
}
