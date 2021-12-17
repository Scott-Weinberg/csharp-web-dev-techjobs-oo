using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TechJobsOO
{
    public class Job : JobFeild
    {
    
        public string Name { get; set; }
        public Employer EmployerName { get; set; } 
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreComepetency) : base()
        { 
            Name = name;
            EmployerName = employerName;
            EmployerLocation= employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreComepetency;
        }
        public override string ToString()
        {

            if (Name == "" || Name == null)
            {
                Name = "Data not available ";
            }

            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available ";
            }

            if (EmployerLocation.Value == "" || EmployerLocation.Value == null)
            {
                EmployerLocation.Value = "Data not available ";
            }

            if (JobType.Value == "" || JobType.Value == null)
            {
                JobType.Value = "Data not available ";
            }

            if (JobCoreCompetency.Value == "" || JobCoreCompetency.Value == null)
            {
                EmployerLocation.Value = "Data not available ";
            }
            //string output 
            return "Id: " + Id + " \n" +
                "Name: " + Name + " \n" +
                "Employer: " + EmployerName.Value + " \n" +
                "Location: " + EmployerLocation + " \n" +
                "Position: " + JobType.Value + " \n" +
                "Core Competenecy: " + JobCoreCompetency.Value + " \n";
                
        }
           
            
        
    
 
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

       /* public ICollection ToString(object name)
        {
            throw new NotImplementedException();
        }*/

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
