using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class Publication
    {
        public int PublicationID { get; set; }
        [Required(ErrorMessage = "")]
        public int PropertyID { get; set; }
        [Required(ErrorMessage = "")]
        public int CommentID { get; set; }
        [Required(ErrorMessage = "")]
        public string content { get; set; }
        public virtual Property Property { get; set; }
        public virtual CommentProperty CommentProperty {get;set;}
    }
}
