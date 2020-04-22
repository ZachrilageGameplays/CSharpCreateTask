using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyShopperV2
{
    class Program
    {
        private static List<string> ShoppingList = new List<string>() { "" };
        private static List<string> ShoppingListFinal = new List<string>() { "" };
        private static string AddItem()
        {
            List<string> ShoppingList = new List<string>() { "" };    
            Console.Write("Enter item: ");
            string item = Console.ReadLine();
            return item;
        }
        private static void SortShoppingList(List<string> list)
        {

        }
        private static void ReturnShoppingListFinal()
        {

        }
        static void Main(string[] args)
        {
            Console.Write("Are you shopping at Hannafords? ");
            string answer = Console.ReadLine();
            if (answer.ToUpper() != "YES")
            {
                Environment.Exit(1);
            }
            Console.Write("How many items are on your list? ");
            int itemcount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= itemcount; i++)
            {
                ShoppingList.Add(AddItem());
            }
            SortShoppingList(ShoppingList);
            ReturnShoppingListFinal();
            for (int j = 0; j <= itemcount; j++)
            {
                Console.WriteLine(ShoppingList[j]);
            }
            Console.ReadKey();
        }
    }
}
