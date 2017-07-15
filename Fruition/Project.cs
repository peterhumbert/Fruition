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
        private List<Activity> pastActivities { get; set; }
        private string category { get; set; }

        public int getDaysSinceLastActive()
        {
            return lastActive.Day - startDate.Day;
        }

        public int getDaysElapsed()
        {
            return DateTime.Now.Day - startDate.Day;
        }

        public void updateLastActiveActivity(string label)
        {
            Activity prevActivity = new Activity(this.lastActiveActivity, this.lastActive);
            pastActivities.Add(prevActivity);
            this.lastActive = DateTime.Now;
            this.lastActiveActivity = label;
        }

        public void updateLastActiveActivity(string label, DateTime dt)
        {
            updateLastActiveActivity(label);
            this.lastActive = dt;
        }
    }
}
