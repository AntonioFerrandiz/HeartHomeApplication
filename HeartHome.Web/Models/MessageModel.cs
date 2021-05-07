using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class MessageModel
    {
        [Required]
        public int MessageID { get; set; }

        [Required]
        public int LessorID { get; set; }

        [Required]
        public int TenantID { get; set; }

        [StringLength(250, ErrorMessage = "El mensaje debe tener un máximo de 250 caracteres.")]
        public string Content { get; set; }
    }
}
