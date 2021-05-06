using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace HeartHome.Web.Models
{
    public class PropertyModel
    {
        public int PropertyID { get; set; }
        public int CityID { get; set; } //FK
        public int LessorID { get; set; } //FK
        public string Type { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
    }
}
