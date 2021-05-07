using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class BankAccount
    {
        [Required]
        public int BankAccountID { get; set; }

        [Required]
        public int BankID { get; set; }

        [Required(ErrorMessage = "Debe ingresar el número de la tarjeta.")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "El número de la tarjeta debe tener 16 dígitos")]
        public int AccountNumber { get; set; }

        //REVISAR LO DE ABAJITO
        [Required(ErrorMessage ="Debe ingresar la fecha de expiración de la tarjeta.")]
        public string DateExpiration { get; set; }

        [Required]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "El número de cuenta debe tener 3 dígitos")]
        public int CVC { get; set; }

        public ICollection<Lessor> Lessors { get; set; }

        public ICollection<Tenant> Tenants { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
