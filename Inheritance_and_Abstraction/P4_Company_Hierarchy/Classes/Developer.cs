using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_Company_Hierarchy.Classes
{
    class Developer : RegularEmployee
    {
        private Dictionary<string, Dictionary<DateTime, Dictionary<string, string>>> _projects = new Dictionary<string, Dictionary<DateTime, Dictionary<string, string>>>();
        public Developer(int id, string firstName, string lastName, double salary, string department)
            : base(id, firstName, lastName, salary, department)
        {}

        public Dictionary<string, Dictionary<DateTime, Dictionary<string, string>>> GetProjects
        {
            get { return this._projects; }
        }
        public void AddProjects(string projectName, DateTime startDate, string details, string state)
        {
            this._projects.Add(
                                details,
                                new Dictionary<DateTime,Dictionary<string,string>>()
                                {
                                    {
                                        startDate, new Dictionary<string,string>() 
                                        {
                                            {projectName, state}
                                        } 
                                     }
                                }
                               );
        }
        
        public void CloseProject(string projectName)
        {
            for (int i = 0; i < this.GetProjects.Count(); i++)
            {
                string check = GetProjects.ElementAt(0).Value.ElementAt(0).Value.ElementAt(0).Key;
                if (check == projectName)
                {
                    this.GetProjects.ElementAt(i).Value.ElementAt(0).Value[projectName] = "close";
                }
            }
        }
        public override string ToString()
        {
            string result = String.Format("\t\t\t\tDeveloper: \nFirst Name: {0};   Last Name {1};   Salary {2};   Department: {3}; \n\t\t\t\tProject:\n", this.FirstName, this.LastName, this.Salary, this.Department);
            foreach (var project in this._projects)
            {
                result += String.Format("Project Name: {0}; Project Start Data: {1} Project Detail: {2}; project State: {3}\n", project.Value.ElementAt(0).Value.ElementAt(0).Key,

                                                                                                      project.Value.ElementAt(0).Key, project.Key, project.Value.ElementAt(0).Value.ElementAt(0).Value); 
            }
            
            return result;
        }
       
    }
}
