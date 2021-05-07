using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Bank
    {
        [Required]
        public int BankID { get; set; }

        [Required(ErrorMessage = "Debe agregar el nombre del banco.")]
        public string Name { get; set;}

        public ICollection<BankAccount> BankAccounts { get; set; }
    }
}
