using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    internal class Costumerss
    {
        public int Number { get; private set; }
        public bool Name { get; private set; }

        public class CostumerCatalog
        {
            List<Costumerss> _costumers;

            public CostumerCatalog()
            {
                _costumers = new List<Costumerss>();
            }

            public void Create(Costumerss c)
            {
                _costumers.Add(c);
            }

            public void PrintCostumers()
            {
                Console.WriteLine(" Menu:");
                Console.WriteLine("****************************");
                foreach (var c in _costumers)
                {
                    Console.WriteLine($"{c}");
                }

            }

            public Costumerss Read(int n)
            {
                foreach (var c in _costumers)
                {
                    if (c.Number == n)
                    {
                        return c;
                    }

                }
                return null;

            }
            public Costumerss SearchCostumers(string Name)
            {
                foreach (var c in _costumers)
                {
                    if (c.Name)
                    {
                        return c;
                    }

                }
                return null;

            }
            public void Update(Costumerss costumers)
            {
                foreach (var c in _costumers)
                {
                    if (c.Number == costumers.Number)
                    {
                        c.Name = costumers.Name;

                        return;
                    }

                }

            }
            //public void Delete(int costumerno)
            //{

            //    Costumerss foundCostumer = null;

            //    foreach (var c in _costumers)
            //    {
            //        if (c.Number == c)
            //        {

            //            foundCostumer = c;
            //        }


            //    }

            //    if (foundCostumer != null)
            //    {
            //        _costumers.Remove(foundCostumer);
            //    }
            //}
        }
    }
}

