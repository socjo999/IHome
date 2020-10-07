using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IHome.Models
{
    public class Data
    {
        public int ID { get; set; }       
        public int S1 { get; set; }
        public int S2 { get; set; }
        public int S3 { get; set; }
        public int S4 { get; set; }
        public int S5 { get; set; }
        public int S6 { get; set; }
        public int S7 { get; set; }
        public int S8 { get; set; }
        public int S9 { get; set; }
        public int S10 { get; set; }
        public int S11 { get; set; }
        public int S12 { get; set; }
        public int S13 { get; set; }
        public int S14 { get; set; }
        public int S15 { get; set; }
        public int S16 { get; set; }
        //[Range(typeof(DateTime),"2006/12/01" , "3/4/2004",  ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime InsertDate { get; set; }
        public Action Action { get; set; }
        public Devices Devices { get; set; }

    }
}
