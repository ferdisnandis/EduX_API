using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduX_API.Domains
{
    public class Dica : BaseDomain
    {
        
        [Column(TypeName = "varchar(255)")]
        public string Texto { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Imagem { get; set; }

        //IdUsuario : FK
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }

        public List<Curtida> Curtidas { get; set; }

        [NotMapped]
        public int TotalCurtidas { get; set; }
    }
}
