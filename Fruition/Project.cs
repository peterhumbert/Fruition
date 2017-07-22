using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruition
{
    enum Statuses { Abandoned=-1, Queued, Underway, Complete }

    class Project
    {
        public Statuses currentStatus { get; set; }
        public bool isComplete { get; set; }
        public DateTime startDate { get; set; }
        public string name { get; set; }
        public DateTime lastActive { get; set; }
        public string lastActiveActivity { get; set; }
        public List<Activity> pastActivities { get; set; }
        public string category { get; set; }

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
