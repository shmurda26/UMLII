using System;

namespace UML2
{
    public class Store
    {
        MenuCatalog menuCatalog;

        public Store()
        {
            menuCatalog = new MenuCatalog();
        }
        public void pizza()
        {
            Pizza p = new Pizza() { Number = 1, Name = "merguez", Price = 50 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 2, Name = "thede", Price = 55 };
            menuCatalog.Create(p);

            p = new Pizza() { Number = 3, Name = "Pizza#3", Price = 65 };
            menuCatalog.Create(p);

            menuCatalog.PrintMenu();

            Console.WriteLine();
            int pizzaToBeFound = 3;
            Console.WriteLine($"Finding Pizza {pizzaToBeFound}");
            Pizza foundPizza = menuCatalog.Read(pizzaToBeFound);
            Console.WriteLine(foundPizza);

            Console.WriteLine();
            string searchCriteria = "PIZZA#1";
            Console.WriteLine($"Finding Pizza starting with: {searchCriteria}");
            foundPizza = menuCatalog.SearchPizza(searchCriteria);
            Console.WriteLine(foundPizza);

            //Console.WriteLine();
            // Console.WriteLine($"Updating Pizza #{foundPizza.Number}");
            // foundPizza.Name += " (Updated)";
            // menuCatalog.Update(foundPizza);

            Console.WriteLine();
            menuCatalog.PrintMenu();

            Console.WriteLine();
            int pizzaToBeDeleted = 2;
            Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            menuCatalog.Delete(pizzaToBeDeleted);
            Console.WriteLine();
            menuCatalog.PrintMenu();

        }
        public void Run()
        {
            new Userdialog(menuCatalog).Run();
        }

        //internal void Run()
        //{
        //    throw new NotImplementedException();
        //}

        //    public void Run()
        //    {
        //        new Userdialog(menuCatalog).Run();
        //    }
        //}
    }
}

        