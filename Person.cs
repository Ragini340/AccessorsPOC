using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class Person
    {
        // Field
        private string name;

        // Property
        public string Name   
        {
            get { return name; }
            set { name = value; }
        }
    }
}