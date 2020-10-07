using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Action
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public Devices  Devices { get; set; }
        public ICollection <Data> Datas { get; set; }
        public ICollection<Scheduler> Schedulers { get; set; }
        public ICollection<Condition> Conditions { get; set; }
    }
}
