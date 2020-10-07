using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Scheduler
    {
        public int ID { get; set; }
        [Required]
        public Action Action { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime At { get; set; }
        public DateTime For { get; set; }

    }
}
