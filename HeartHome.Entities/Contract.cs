using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Contract
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

        public virtual Tenant Tenant { get; set; }

        public virtual Property Property { get; set; }

        public virtual Lessor Lessor { get; set; }
    }
}
