using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Lessor
    {
        [Required]
        public int LessorID { get; set; }

        [Required]
        public int AccountID { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del propietario.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe ingresar el apellido del propietario.")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Debe ingresar el email del propietario.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Debe ingresar el DNI del propietario")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El DNI debe tener de 8 digitos.")]
        public int Dni { get; set; }

        [Required(ErrorMessage = "")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El número de celular debe tener 9 digitos")]
        public int Phone { get; set; }

        public ICollection<Property> Properties { get; set; }

        public ICollection<Message> Messages { get; set; }

        public ICollection<CommentTenant> CommentTenants { get; set; }

        public ICollection<Contract> Contracts { get; set; }

        public virtual BankAccount BankAccount { get; set; }
    }
}
