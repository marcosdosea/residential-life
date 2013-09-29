using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Models
{
    public class VotoEnqueteModel
    {
        public int IdVoto { get; set; }
        public int IdPessoa { get; set; }
        public int IdEnquete { get; set; }
        public int IdOpcao { get; set; }
        public DateTime DataVoto { get; set; }
    }
}
