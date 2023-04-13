using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML2
{
    public class Userdialog
    {
        MenuCatalog _menuCatalog;

        public Userdialog(MenuCatalog menuCatalog)
        {
            _menuCatalog = menuCatalog;
        }

        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("      create your pizza");
            Console.WriteLine("=========================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Enter name");
            pizzaItem.Name = Console.ReadLine();

            string input = "";
            Console.Write("Enter price");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Price = int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Unable to make a price with the extra letter/sign you added in the price thats meant to be made out of numbers you donut fix {input}now or quit-message:{e.Message}");
                throw;
            }

            input = "";
            Console.Write("enter the pizza id");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Number = int.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"unable to {input}-message:{e.Message}");
                throw;
            }
            return pizzaItem;
        }
        int MainMenuChoice(List<string> menuItem)
        {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("pizza menu");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("options");
            foreach (string choice in menuItem)
            { Console.WriteLine(choice);
            }
            Console.WriteLine("enter option#:");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = int.Parse(input);
                return result;
            }
            catch (FormatException) { Console.WriteLine($"unable to parse {input}"); }
            return -1; }
        public void Run()
        { bool proceed = true;
            List<string> mainmenulist = new List<string>()
            { "0. Quit",
                "1.Create a Pizza",
                "2. print menu",
                "3.Some choice"
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainmenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 0:
                        proceed = false;
                        Console.WriteLine("Quitting");
                        break;
                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        _menuCatalog.PrintMenu();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"You selected: {mainmenulist[MenuChoice]}");
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 4:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _menuCatalog.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
//while (proceed)
//{
//    int MenuChoice = MainMenuChoice(mainmenulist);
//    Console.WriteLine();
//    switch (MenuChoice)
//    { case 0: proceed = false;
//            Console.WriteLine("shutting down");
//            break;
//        case 1: try
//            { Pizza pizza = GetNewPizza();
//                _menuCatalog.create(pizza);
//                Console.WriteLine($"your creation{pizza}");
//            }


//            catch (Exeption)
//            { Console.WriteLine($"nothing was created");
//            }
//            Console.Write("hit anything to continue");
//            Console.ReadKey();
//            break;


//        case 2:
//            _menuCatalog.PrintMenu();
//            Console.Write("Hit any key to continue");
//            Console.ReadKey();
//            break;
//        case 3:

//            Console.Write($"You selected: {mainMenulist[MenuChoice]}");
//            Console.Write("Hit any key to continue");
//            Console.ReadKey();
//            break; }
//    default;
//            Console.Write("Hit any key to continue");
//    Console.ReadKey();

//    break;
//} } } }












