using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class CommentProperty
    {
        public int CommentID { get; set; }
        [Required(ErrorMessage = "")]
        public int TenantID { get; set; }
        [Required(ErrorMessage = "")]
        public int Date { get;set; }
        [Required(ErrorMessage = "")]
        public string Detail { get; set; }
        public ICollection<Publication> Publications { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
