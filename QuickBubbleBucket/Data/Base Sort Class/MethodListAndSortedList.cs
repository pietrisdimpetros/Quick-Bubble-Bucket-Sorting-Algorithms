using QuickBubbleBucket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBubbleBucket.BaseSortClass
{
    public static class MethodListAndSortedList
    {
        public static int ChooseMethod()
        {
            // Make the Sorting Method selection Menu
            return  Menus.SelectionMenu(true, "Which Method would you like to use?\nPress escape to exit" +
                "", 2,30,
                "Size Ascending",
                "Size Descending",
                "Color Ascending",
                "Color Descending",
                "Fabric Ascending",
                "Fabric Descending",
                "Size->Color->Fabric Ascending",
                "Size->Color->Fabric Descending");
        }
        public static int PrintNewSortedList(List<TShirt> shirts)
        {
            int yaxis = 20;
            Console.Clear();
            Console.SetCursorPosition(80, yaxis++);
            Console.WriteLine("This is your new Data");
            foreach (var shirt in shirts)
            {
                Console.SetCursorPosition(80, yaxis++);
                shirt.Stringify(shirt);
            }
            Console.SetCursorPosition(80, yaxis++);
            Console.WriteLine("Press any key to continue.");
            return -1;
        }
    }
}
