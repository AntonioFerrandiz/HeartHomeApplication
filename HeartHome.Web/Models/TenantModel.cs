using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class TenantModel
    {
        [Required]
        public int TenantID { get; set; }

        [Required]
        public int AccountID { get; set; }

        [Required]
        public int CommentID { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del inquilino.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre del inquilino debe tener de 3 a 50 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido del inquilino.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El apellido del inquilino debe tener de 3 a 50 caracteres")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Debe ingresar el email del inquilino.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El dni debe tener 8 digitos")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El número debe tener 9 digitos")]
        public int Phone { get; set; }
    }
}
