using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class CommentPropertyModel
    {
        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ser un inquilino para comentar sobre la propiedad.")]
        public int TenantID { get; set; }

        [Required]
        public int Date { get; set; }

        [Required(ErrorMessage = "Debe ingresar el comentario.")]
        public string Detail { get; set; }
    }
}
