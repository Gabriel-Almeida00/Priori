using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_OBJ.Models
{
    public class tblCarteiraInvestimentos
    {
        public int id_carteira { get; set; }
        public int id_cliente { get; set; }
        public tblClientes cliente { get; set; }
        public int id_investimento { get; set; }
        public tblInvestimentos investimento {get; set; }
        public virtual ICollection<tblInvestimentos> Investimentos { get; set; }
        public DateTime data_efetuacao { get; set; }
        public Decimal valor_aplicado { get; set; }
        public int tempo_aplicacao { get; set; }
        public DateTime duracao { get; set; }

        public Decimal saldo { get; set; }
    }
}
