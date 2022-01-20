using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo03
{
    internal class Instructor
    {
        public string Name { get; private set; }
        public EmploymentType EmploymentType { get; private set; } = EmploymentType.FullTime;

        public Instructor(string Name, EmploymentType employmentType)
        {
            if (Utilities.IsValidNameLength(Name, 5) == false)
            {
                throw new ArgumentException("Instructor Name must not be null or empty and must contain 5 or more characters in length");
            }
        }
    }
}
