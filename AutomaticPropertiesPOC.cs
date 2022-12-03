using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class AutomaticPropertiesPOC
    {
        static void Main(string[] args)
        {
            AutomaticProperties Obj = new AutomaticProperties();
            Obj.Name = "Ragini Ragini";
            Console.WriteLine(Obj.Name);
        }
    }
}
