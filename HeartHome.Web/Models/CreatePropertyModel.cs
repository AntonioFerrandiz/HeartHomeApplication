using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class CreatePropertyModel
    {
        [Required(ErrorMessage = "Debe ingresar el tipo de propiedad.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El tipo de propiedad debe tener de 3 a 50 caracteres")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Debe ingresar la dirección de la propiedad.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La dirección debe tener de 3 a 50 caracteres")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre de la propiedad.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la propiedad debe tener de 3 a 50 caracteres")]
        public string Name { get; set; }


    }
}
