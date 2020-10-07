using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Groups
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Zones")]
        public int FK_Zone { get; set; }
        public ICollection<Devices> Devices { get; set; }
    }
}
