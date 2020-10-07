using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Devices
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public Zones Zones { get; set; }
        [Required]
        public Buildings Building { get; set; }
        public Groups Groups { get; set; }
        public ICollection<Action> Actions { get; set; }
        public ICollection<Data> Datas { get; set; }
    }
}
