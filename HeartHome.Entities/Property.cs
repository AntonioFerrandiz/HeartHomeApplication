using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Property
    {
        public int PropertyID { get; set;}
        [Required(ErrorMessage ="")]
        public int CityID { get; set; } //FK
        [Required(ErrorMessage = "")]
        public int LessorID { get; set; } //FK
        [Required(ErrorMessage = "")]
        public string Type { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El tipo de propiedad debe tener de 3 a 50 caracteres")]
        public string Address { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La dirección debe tener de 3 a 50 caracteres")]
        public string Name { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la propiedad debe tener de 3 a 50 caracteres")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El número debe tener 9 digitos")]

        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public virtual City City { get; set; }
        public virtual Lessor Lessor { get; set; }
    }
}
