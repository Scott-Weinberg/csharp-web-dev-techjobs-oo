﻿using System;
using System.Collections;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
       
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreComepetency) : this()
        { 
            Name = name;
            EmployerName = employerName;
            EmployerLocation= employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreComepetency;
        }
 public Job()
        {
            Id = nextId;
            nextId++;
        }
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public ICollection ToString(object name)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
