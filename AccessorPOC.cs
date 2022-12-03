using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class AccessorPOC
    {
        public static void Main(string[] args)
        {
            AccessorSpecifierPOC obj = new AccessorSpecifierPOC();

            // Calling set accessor of the property Name,and passing "RaginiSingh" as value of the standard field 'value'.
            obj.Name = "RaginiSingh";

            // Displaying RaginiSingh, Calling the get accessor of the property Name.
            Console.WriteLine("Name: " + obj.Name);
        }
    }
}
