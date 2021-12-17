using System;
namespace TechJobsOO
{
    public class PositionType : JobFeild
    {
        public PositionType(string value) : base(value)
        {

        }

        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is PositionType type &&
                   Id == type.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
