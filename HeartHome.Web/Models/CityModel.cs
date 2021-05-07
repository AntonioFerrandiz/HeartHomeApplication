using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class CityModel
    {
        [Required]
        public int CityID { get; set; }

        [Required(ErrorMessage = "Debe agregar el nombre de la ciudad.")]
        public string Name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Debe agregar el nombre del País.")]
        public string Country { get; set; }
    }
}
