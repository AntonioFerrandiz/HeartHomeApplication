using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class CommentProperty
    {
        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ser un inquilino para comentar sobre la propiedad.")]
        public int TenantID { get; set; }

        [Required]
        public int Date { get;set; }

        [Required(ErrorMessage = "Debe ingresar el comentario.")]
        public string Detail { get; set; }

        public ICollection<Publication> Publications { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}
