using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class CostumerCatalog
    {
        public class Costumers
        {
            public Costumers(int number, string name)
            {
                Number = number;
                Name = name;
            }

            public int Number { get; set; }
            public string Name { get; set; }
            
            public override string ToString()
            {
                return ($"\nNo{Number} \nName{Name}  ");
            }
        }
    }
}

