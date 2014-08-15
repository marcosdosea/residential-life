using System;

namespace Models
{
    public class VotoEnqueteModel
    {
        public int IdVoto { get; set; }
        public int IdPessoa { get; set; }
        public int IdEnquete { get; set; }
        public int IdOpcao { get; set; }
        public DateTime DataVoto { get; set; }
        public string Descricao { get; set; }
        public string TituloEnquete { get; set; } 
    }
}
