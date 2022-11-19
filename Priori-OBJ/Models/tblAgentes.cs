using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_OBJ.Models
{
    public  class tblAgentes 
    {
        public int agente_id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public decimal salario { get; set; }
        public DateTime data_contratacao { get; set; }
        public DateTime data_demissao { get; set; }
        public string estado { get; set; }
        public virtual ICollection<tblClientes> cliente { get; set; }

    }
}
