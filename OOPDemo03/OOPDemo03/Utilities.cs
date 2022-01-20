using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo03
{
    //Prevents the user from creating an object (instance) of this class
    //Static class prevents:
    //  Console con = new Console();
    //  Console.WriteLine(), Console.ReadLine(), Math.Round(), Math.Pow()
    internal static class Utilities
    {
        public static bool IsValidNameLength(string name, int minLength)
        {
            bool isValid = false;
            if (!string.IsNullOrEmpty(name) && name.Trim().Length >= minLength)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
