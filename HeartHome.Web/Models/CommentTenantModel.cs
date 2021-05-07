using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class CommentTenantModel
    {
        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ser un propietario para opinar sobre un inquilino.")]
        public int LessorID { get; set; }

        [Required]
        public int Date { get; set; }

        [Required(ErrorMessage = "Debe ingresar el comentario.")]
        public string Detail { get; set; }
    }
}
