using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class StudentTest
    { // Main Method
        public static void Main(string[] args)
        {

            // Creating three instances of Student class it call constructor three times which increase the counter
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Console.WriteLine("Total No of Student: " + Student.Counter);
        }
    }
}

