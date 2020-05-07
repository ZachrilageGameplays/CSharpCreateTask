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

        //Initialize the detecion for Shopping at Hannafords.
        private static void ShoppingAtHannafords()
        {
        Console.Write("Are you shopping at Hannafords?\n>");
            Console.ForegroundColor = ConsoleColor.White;
            string answer = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Green;
            if (answer.ToUpper() != "YES")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("This code is meant to be specific to Hannafords only,\nso it is pointless to sort your list via aisle if you\naren't shopping at Hannafords.\n\nGoodbye!");
                Console.ReadKey();
                Environment.Exit(1);
            }
        }
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
        private static void SortandDisplay(List<string> list, int itemcount)
        {
            //sets up location for all the aisles to go to be iterated through.
            List<List<string>> aisles = new List<List<string>>();
            
            //Declares list of all the items in all of the aisles available.
            List<string> aisle1 = new List<string>() { "mexican", "international", "gourmet", "pasta", "pizza dough", "pizza sauce", "rice" };
            List<string> aisle2 = new List<string>() { "asain foods", "bbq sauce", "beans", "mayo", "mustard", "relish", "salad dressing", "shortening", "soups", "canned vegetables" };
            List<string> aisle3 = new List<string>() { "baking needs", "baking", "bake ware", "cake mixes", "cake decor", "chocolate chips", "coconut", "cooking oil", "flour", "canned fruits", "gravy", "jams/jellies", "pudding", "salt", "spices", "stuffing", "sugar", "peanut butter" };
            List<string> aisle4 = new List<string>() { "cereal", "granola", "Honey", "oats", "pancake mix" };
            List<string> aisle5 = new List<string>() { "bread", "cocoa", "coffee", "syrup", "tea" };
            List<string> aisle6 = new List<string>() { "juices", "seltzer" };
            List<string> aisle7 = new List<string>() { "cookies", "crackers", "soda" };
            List<string> aisle8 = new List<string>() {  };
            List<string> aisle9 = new List<string>() { "chips", "seasonal" };
            List<string> aisle10 = new List<string>() { "aluminum foil", "freezer wrap", "napkins", "tissues" };
            List<string> aisle11 = new List<string>() { "matches" };
            List<string> aisle12 = new List<string>() { "house", "mop", "broom", "cleaning" };
            List<string> aisle13 = new List<string>() { "nuts" };
            List<string> aisle14 = new List<string>() { "frozen foods" };
            
            //Adds all the aisles to the list of aisles.
            aisles.Add(aisle1);
            aisles.Add(aisle2);
            aisles.Add(aisle3);
            aisles.Add(aisle4);
            aisles.Add(aisle5);
            aisles.Add(aisle6);
            aisles.Add(aisle7);
            aisles.Add(aisle8);
            aisles.Add(aisle9);
            aisles.Add(aisle10);
            aisles.Add(aisle11);
            aisles.Add(aisle12);
            aisles.Add(aisle13);
            aisles.Add(aisle14);
            
            //Sets count for the aisle number.
            int count = 1;
            
            //Iterating through each aisle.
            foreach (var aisle in aisles)
            {
                //Write what aisle it is searching through for the items on the list.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("These items are in aisle " + count + ":");
                
                //Iterates through all of the items in the current aisle.
                foreach(var item in aisle)
                {
                    //Compares all of the items on the shopping list to the current item in the list.
                    foreach(var item2 in ShoppingList)
                    {
                        //If both items are the same, write the item underneath the aisle it was searching through.
                        if (item2 == item)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(item2);
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                }
                //increase the count number so that you know what aisle the item was found.
                count++;
            }
            //A little plug at the end to tell the user that the program is still early in development, and while the code is done, it might not work to the user's full intent, and where to give thoughts and suggestions.
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please keep in mind while this is a 2nd version to Speedy Shopper it is still in Alpha testing.\nPlease don't be surprised about items not being specific or in the proper aisles,\nit is merely a proof of concept and something that might be fleshed out in the future.\nComments? Ideas? Post it on my GitHub! @");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("https://github.com/ZachrilageGameplays/CSharpCreateTask");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n\nPress Any Key To Close The Program. . .");
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("|         Welcome to Speedy ShopperV2!         |");
            Console.WriteLine("|     Use this program to save you time by     |");
            Console.WriteLine("|  having it organize your shopping list for   |");
            Console.WriteLine("|    you so you know what is in each aisle!    |");
            Console.WriteLine("|                                              |");
            Console.WriteLine("|    *Please be generic in what you choose     |");
            Console.WriteLine("|    to enter. (i.e. Instead of whole wheat    |");
            Console.WriteLine("|           bread just type bread.)*           |");
            Console.WriteLine("------------------------------------------------");
            /***************************************************************************
            *   ^                                                             ^        *
            *   |                                                             |        *
            * This code was meant to be realistic, and useful. So, in creating this,   *
            * I wanted to get a map of some of the stores local to myself, but the     *
            * only one that I could get a map of was the local Hannafords. Thus, I     *
            * made a confirmation bit to ensure that the user was shopping at Hanna-   *
            * fords, and if they weren't, then it would tell the user that the program *
            * is pointless if you aren't, and proceeds to close the program.           *
            *   |            |                                                         *
            *   v            v                                                         *
            ***************************************************************************/
            ShoppingAtHannafords();
            //If the user answered that they were shopping at Hannafords, the program runs itemcount, and assigns it to variable item_count.
            var item_count = itemcount();
            for (int i = 1; i <= item_count; i++)
            {
                ShoppingList.Add(AddItem());    //This runs the add item code up top, which returns a string, that is then added to ShoppingList.
            }
            SortandDisplay(ShoppingList, item_count);     //This runs the code that sorts the shopping list, and returns the output.
            Console.ReadKey();    //Leaves the result on screen long enough for the user to see the result and do what they would like with it, before allowing the user to close the program.
        }
    }
}
