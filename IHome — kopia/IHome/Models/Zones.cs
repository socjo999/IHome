using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Zones
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public Buildings Buildings { get; set; }
        public ICollection<Groups> Groups { get; set; }
        public ICollection<Devices> Devices { get; set; }
    }
}
