using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HeartHome.Web.Models
{
    public class ContractModel
    {
        [Required]
        public int ContractID { get; set; }

        [Required]
        public int TenantID { get; set; }

        [Required]
        public int PropertyID { get; set; }

        [Required]
        public int LessorID { get; set; }

        [Required]
        public string DateContract { get; set; }

        [Required(ErrorMessage = "Debe agregar los detalles del contrato.")]
        public string detail { get; set; }
    }
}
