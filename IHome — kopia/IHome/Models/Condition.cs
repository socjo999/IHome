using System.ComponentModel.DataAnnotations.Schema;

namespace IHome.Models
{
    public class Condition
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int State { get; set; }
        public string  ConditionString { get; set; }
        public bool FillCondition { get; set; }
        [ForeignKey("ActionID")]
        public Action Action { get; set; }
    }
}
