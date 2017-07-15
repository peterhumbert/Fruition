using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruition
{
    class Activity
    {
        private string label { get; set; }
        private DateTime timestamp { get; set; }

        // CONSTRUCTORS
        public Activity() { }

        public Activity(string label, DateTime timestamp)
        {
            this.label = label;
            this.timestamp = timestamp;
        }
    }
}
