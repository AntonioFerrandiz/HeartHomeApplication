using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class BankModel
    {
        [Required]
        public int BankID { get; set; }

        [Required(ErrorMessage = "Debe agregar el nombre del banco.")]
        public string Name { get; set; }
    }
}
