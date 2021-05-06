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
        public int ContractID { get; set; }
        [Required(ErrorMessage = "")]
        public int TenantID { get; set; }
        [Required(ErrorMessage = "")]
        public int PropertyID { get; set; }
        [Required(ErrorMessage = "")]
        public int LessorID { get; set; }
        [Required(ErrorMessage = "")]
        public string DateContract { get; set; }
        [Required(ErrorMessage = "")]
        public string detail { get; set; }

        public virtual Tenant Tenant { get; set; }
        public virtual Property Property { get; set; }
        public virtual Lessor Lessor { get; set; }
    }
}
