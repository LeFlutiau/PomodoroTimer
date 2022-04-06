using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pomodoro
{
    [Serializable()]
    public class Task
    {
        public string Name { get; set; }
        public int Planned { get; set; }
        public int Elapsed { get; set; }
        public int State { get; set; }          // 0 = created, 1 = completed
        public System.DateTime TSCreated { get; set; }
        public System.DateTime TSCompleted { get; set; }
    }
}
