using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Models
{
    public class OpcoesEnqueteModel
    {
        public EnqueteModel Enquete{ get; set; }
        public IList<OpcaoModel> Opcoes{ get; set; }
    }
}
