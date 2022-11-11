using Microsoft.AspNetCore.Identity;

namespace Priori_OBJ.Models
{
    public class Funcao : IdentityRole<string>
    {
        public string Descricao { get; set; }
    }
}
