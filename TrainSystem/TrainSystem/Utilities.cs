using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    public static class Utilities
    {
        public static bool IsEmpty(string value)
        {
            bool valid = false;
            if (string.IsNullOrWhiteSpace(value))
            {
                valid = true;
            }
            return valid;
        }

        //overloaded methods
        public static bool HPCheck(int value) /*fix this*/
        {
            bool valid = false;
            if (value >= 3500 || = 5500 )
            {
                valid = true;
            }
            return valid;
        }
        public static bool IsPositive(int value)
        {
            bool valid = false;
            if (value >= 0)
            {
                valid = true;
            }
            return valid;
        }
    }
}
