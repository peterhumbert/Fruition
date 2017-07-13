using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruition
{
    class Project
    {
        private DateTime startDate { get; set; }
        private string name { get; set; }
        private string status { get; set; }
        private DateTime lastActive { get; set; }
        private string lastActiveActivity { get; set; }
        // record of activities
        private string category { get; set; }

        public int getDaysSinceLastActive()
        {
            return lastActive.Day - startDate.Day;
        }

        public int getDaysElapsed()
        {
            return DateTime.Now.Day - startDate.Day;
        }
    }
}
