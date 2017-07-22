using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruition
{
    class Activity
    {
        public string label { get; set; }
        public DateTime timestamp { get; set; }

        // CONSTRUCTORS
        public Activity() { }

        public Activity(string label, DateTime timestamp)
        {
            this.label = label;
            this.timestamp = timestamp;
        }
    }
}
