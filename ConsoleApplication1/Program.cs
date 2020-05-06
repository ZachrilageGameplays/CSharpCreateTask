using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyShopperV2
{
    class Program
    {
        //Initializes the two shopping lists for later use.
        private static List<string> ShoppingList = new List<string>() { "" };
        private static List<string> ShoppingListFinal = new List<string>() { "" };

        //Method that allows the user to add the items that they have on their shopping list to the list called ShoppingList.
        private static string AddItem()
        {
            List<string> ShoppingList = new List<string>() { "" };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter item: ");
            Console.ForegroundColor = ConsoleColor.White;
            string item = Console.ReadLine();
            return item;
        }
        //This method sorts all of the items previously added to shopping list.
        private static int itemcount()
        {
            Console.Write("How many items are on your list?\n>");
            Console.ForegroundColor = ConsoleColor.White;
            int itemcount = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            return itemcount;
        }
        private static List<string> SortShoppingList(List<string> list, int itemcount)
        {
            List<List<string>> aisles = new List<List<string>>();
            //Declares list of all the items in all of the aisles.
            List<string> aisle1 = new List<string>() { "mexican", "international", "gourmet", "pasta", "pizza dough", "pizza sauce", "rice" };
            List<string> aisle2 = new List<string>() { "asain foods", "bbq sauce", "beans", "mayo", "mustard", "relish", "salad dressing", "shortening", "soups", "canned vegetables" };
            List<string> aisle3 = new List<string>() { "baking needs", "baking", "bake ware", "cake mixes", "cake decor", "chocolate chips", "coconut", "cooking oil", "flour", "canned fruits", "gravy", "jams/jellies", "pudding", "salt", "spices", "stuffing", "sugar", "peanut butter" };
            List<string> aisle4 = new List<string>() { "cereal", "granola", "Honey", "oats", "pancake mix" };
            List<string> aisle5 = new List<string>() { "bread", "cocoa", "coffee", "syrup", "tea" };
            List<string> aisle6 = new List<string>() { "juices", "seltzer" };
            List<string> aisle7 = new List<string>() { "cookies", "crackers", "soda" };
            List<string> aisle8 = new List<string>() { "" };
            List<string> aisle9 = new List<string>() { "chips", "seasonal" };
            List<string> aisle10 = new List<string>() { "aluminum foil", "freezer wrap", "napkins", "tissues" };
            List<string> aisle11 = new List<string>() { "matches" };
            List<string> aisle12 = new List<string>() { "house", "mop", "broom", "cleaning" };
            List<string> aisle13 = new List<string>() { "nuts" };
            List<string> aisle14 = new List<string>() { "frozen foods" };
            aisles.Add(aisle1);
            aisles.Add(aisle2);
            aisles.Add(aisle3);
            aisles.Add(aisle4);
            aisles.Add(aisle5);
            aisles.Add(aisle6);
            aisles.Add(aisle8);
            aisles.Add(aisle9);
            aisles.Add(aisle10);
            aisles.Add(aisle11);
            aisles.Add(aisle12);
            aisles.Add(aisle13);
            aisles.Add(aisle14);
            foreach (var aisle in aisles)
            {
                Console.WriteLine(aisle);
                foreach(var item in aisle)
                {
                    Console.WriteLine(" " + item);
                    foreach(var item2 in ShoppingList)
                    {
                        Console.WriteLine("  " + item2);
                    }
                }
            }
            return list;
        }
        private static void ReturnShoppingListFinal()
        {

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|          Welcome to Speedy Shopper!          |");
            Console.WriteLine("|     Use this program to save you time by     |");
            Console.WriteLine("|  having it organize your shopping list for   |");
            Console.WriteLine("|    you so you know what is in each aisle!    |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|    *Please be generic in what you choose     |");
            Console.WriteLine("|    to enter. (i.e. Instead of whole wheat    |");
            Console.WriteLine("|           bread just type bread.)*           |");
            Console.WriteLine("-----------------------------------------------");
            /***************************************************************************
            * This code was meant to be realistic, and useful. So, in creating this,   *
            * I wanted to get a map of some of the stores local to myself, but the     *
            * only one that I could get a map of was the local Hannafords. Thus, I     *
            * made a confirmation bit to ensure that the user was shopping at Hanna-   *
            * fords, and if they weren't, then it would tell the user that the program *
            * is pointless if you aren't, and proceeds to close the program.           *
            ***************************************************************************/
            Console.Write("Are you shopping at Hannafords?\n>");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            if (answer.ToUpper() != "YES")
            {
                Console.WriteLine("Sorry, but this code is meant to be specific to Hannafords only,\nso it is pointless to sort your list via aisle if you aren't shopping at Hannafords.\nGoodbye!");
                Console.ReadKey();
                Environment.Exit(1);
            }
            var item_count = itemcount();
            for (int i = 1; i <= item_count; i++)
            {
                ShoppingList.Add(AddItem());    //This runs the add item code up top, which returns a string, that is then added to ShoppingList.
            }
            ShoppingListFinal = SortShoppingList(ShoppingList, item_count);     //This runs the code that sorts the shopping list, and returns the sorted list and assigns it to ShoppingListFinal.
            ReturnShoppingListFinal();  //This is one final method that takes ShoppingListFinal, analyzes it, and prints out by aisle the list in order, and at the end prints out what wasn't in any aisle at it's own section.
            Console.ReadKey();
        }
    }
}
