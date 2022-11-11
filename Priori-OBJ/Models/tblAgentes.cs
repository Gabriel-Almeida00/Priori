using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_OBJ.Models
{
    public  class tblAgentes
    {
        public int id_agente { get; set; }
        public string nome { get; set; }
        public decimal cpf { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public decimal salario { get; set; }
        public DateTime data_contratacao { get; set; }
        public DateTime data_demissao { get; set; }
        public string estado { get; set; }
        
    }
}
