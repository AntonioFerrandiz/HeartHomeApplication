using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class CommentTenant
    {
        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ser un propietario para opinar sobre un inquilino.")]
        public int LessorID { get; set; }

        [Required]
        public int Date { get; set; }

        [Required(ErrorMessage = "Debe ingresar el comentario.")]
        public string Detail { get; set; }

        public ICollection<Tenant> Tenants { get; set; }

        public virtual Lessor Lessor { get; set; }
    }
}
