using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobFeild
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }
        public JobFeild(string value)
        {
          Value = value;
        }
        public JobFeild()
        {
            Id = nextId;
            nextId++;
        }

        public override bool Equals(object obj)
        {
            return obj is JobFeild feild &&
                   Id == feild.Id;
                   
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
     /*   public override string ToString()
        {
            return Value;
        }*/
    }
}
