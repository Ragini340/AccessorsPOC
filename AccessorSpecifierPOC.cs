using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessorsPOC
{
    class AccessorSpecifierPOC
    {
        private string name = "Ragini";

        // Declaring name property
        public string Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}

   

       

