using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pomodoro
{
    public enum States
    {
        Created,
        Complete
    }

    [Serializable()]
    public class Task
    {
        public string Name { get; set; }
        public int Planned { get; set; }
        public int Elapsed { get; set; }
        public States State { get; set; }
        public System.DateTime TSCreated { get; set; }
        public System.DateTime TSCompleted { get; set; }
    }
}
