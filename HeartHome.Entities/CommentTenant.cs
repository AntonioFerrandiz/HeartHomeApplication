using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class CommentTenant
    {
        public int CommentID { get; set; }
        [Required(ErrorMessage = "")]
        public int LessorID { get; set; }
        [Required(ErrorMessage = "")]
        public int Date { get; set; }
        [Required(ErrorMessage = "")]
        public string Detail { get; set; }
        public ICollection<Tenant> Tenants { get; set; }
        public virtual Lessor Lessor { get; set; }
    }
}
