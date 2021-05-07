using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class PublicationModel
    {
        [Required]
        public int PublicationID { get; set; }

        [Required]
        public int PropertyID { get; set; }

        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ingresar el cuerpo de la publicación.")]
        [StringLength(300, MinimumLength = 100, ErrorMessage = "El cuerpo de la publicación debe tener entre 100 y 300 caracteres")]
        public string content { get; set; }
    }
}
