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
        public int BankAccountID { get; set; }
        [Required(ErrorMessage ="")]
        public int BankID { get; set; }
        [Required(ErrorMessage ="")]
        public int AccountNumber { get; set; }
        [Required(ErrorMessage ="")]
        [StringLength(16,ErrorMessage ="El número de cuenta debe tener un máximo de 16 dígitos")]
        //REVISAR LO DE ABAJITO
        public string DateCreation { get; set; }
        [Required(ErrorMessage ="")]
        public int CVC { get; set; }
        public ICollection<Lessor> Lessors { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
