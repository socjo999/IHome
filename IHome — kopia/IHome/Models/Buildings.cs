using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Buildings
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Street { get; set; }
        public string Home { get; set; }
        public string Apartament { get; set; }
        public ICollection<Zones> Zones { get; set; }
        public ICollection<Devices> Devices { get; set; }
    }
}
