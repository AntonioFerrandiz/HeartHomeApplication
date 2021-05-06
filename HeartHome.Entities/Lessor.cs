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
        public int LessorID { get; set; }
        [Required(ErrorMessage ="")]
        public int AccountID { get; set; }
        [Required(ErrorMessage = "")]
        public string Name { get; set; }
        [Required(ErrorMessage = "")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "")]
        public string Email { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El nombre de la propiedad debe tener de 3 a 50 caracteres")]
        public int Dni { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "El dni debe tener 8 digitos")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El número debe tener 9 digitos")]
        public ICollection<Property> Properties { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<CommentTenant> CommentTenants { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public virtual BankAccount BankAccount { get; set; }
    }
}
