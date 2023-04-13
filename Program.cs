using System;

namespace UML2
{
    class Program
    {
        static void Main(string[] args)
        {

            //new Store().pizza();
            Store store = new Store();
            {
                Store Store = new Store();
                Store.pizza();
                Console.Write("Hit any key to continue with user dialog");
                Console.ReadKey();
                Store.Run();
            }
        }
    }
}


