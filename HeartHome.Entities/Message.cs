using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        [Required(ErrorMessage = "")]
        public int LessorID { get;set; }
        [Required(ErrorMessage = "")]
        public int TenantID { get; set; }
        [Required(ErrorMessage = "")]
        public string Content { get; set; }
        [MaxLength(50, ErrorMessage ="")]
        public virtual Lessor Lessor { get; set; }
        public virtual Tenant Tenant { get; set; }
        //????????
    }
}
