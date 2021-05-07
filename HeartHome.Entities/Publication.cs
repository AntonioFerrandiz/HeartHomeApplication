using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Publication
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

        public virtual Property Property { get; set; }

        public virtual CommentProperty CommentProperty {get;set;}
    }
}
