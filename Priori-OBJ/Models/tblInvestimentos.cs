using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_OBJ.Models
{
    public  class tblInvestimentos
    {
        public int id_investimento { get; set; }
        public int id_tipoinvestidor { get; set; }
        public tbltipoInvestidor tbltipoInvestidor { get; set; }
        public int nome { get; set; }
        public string tipo_investimento { get; set; }
        public string rentabilidade { get; set; }
        public Decimal valor_minimo { get; set; }
        public int tempo_minimo { get; set; }
        public string descricao { get; set; }
    }
}
