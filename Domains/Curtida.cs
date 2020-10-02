using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Domains
{
    public class Curtida : BaseDomain
    {

        //IdUsuario : FK
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; } 

        //IdDica : FK
        public Guid IdDica { get; set; }
        [ForeignKey("IdDica")]
        public Dica Dica { get; set; }

    }
}
