using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class Student
    {
        // Declaring counter field as cnt
        private static int cnt;

        // Defining constructor
        public Student()
        {
            // Incrementing the counter using constructor
            cnt++;
        }

        // Declaring counter property
        public static int Counter
        {
            // read-only property
            get
            {
                return cnt;
            }
        }
    }
}
   