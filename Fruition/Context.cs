using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruition
{
    class Context
    {
        public string name { get; set; }
        public List<Project> projects;
        public bool isForOrg { get; set; }
        public string slack { get; set; }
        public string trello { get; set; }

        public List<String> getProjectNames()
        {
            List<String> output = new List<String>();

            foreach (Project p in projects)
            {
                output.Add(p.name);
            }

            return output;
        }
    }
}
