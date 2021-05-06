using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartHome.Entities
{
    public class City
    {
        public int CityID { get; set; }
        [Required(ErrorMessage ="")]
        public string Name { get; set; }
        [Required(ErrorMessage = "")]
        [StringLength(50,ErrorMessage ="")]
        public string Country { get; set; }
        [Required(ErrorMessage = "")]
        public ICollection<Property> Properties { get; set; }
    }
    
}
