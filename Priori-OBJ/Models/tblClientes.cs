using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Priori_OBJ.Models
{
    public class tblClientes : IdentityUser<string>
    {
        public string nome { get; set; }
        public int id_tipoinvestidor { get; set; }
        public tbltipoInvestidor tipoInvestidor { get; set; }
        public virtual ICollection<tblCarteiraInvestimentos> CarteiraInvestimentos { get; set; }
        public int id_agente { get; set; }
        public tblAgentes agente { get; set; }
        public Decimal cpf { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public DateTime data_adesao { get; set; }
        public string  estado { get; set; }
    }
}
