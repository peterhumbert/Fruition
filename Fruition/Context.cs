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
        public bool hasSlack { get; set; }
        public bool hasTrello { get; set; }
        public string slack { get; set; }
        public string trello { get; set; }

        public Context()
        {
            projects = new List<Project>();
        }

        public Context(string name) : base()
        {
            this.name = name;
        }

        public void addProject(Project proj)
        {
            projects.Add(proj);
        }

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
