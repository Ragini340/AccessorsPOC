using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class PersonMainMethod
    {
        static void Main(string[] args)
        {
            Person Obj = new Person();
            Obj.Name = "R Singh";
            Console.WriteLine(Obj.Name);
        }
    }
}
