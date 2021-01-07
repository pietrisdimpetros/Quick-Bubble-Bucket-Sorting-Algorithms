using QuickBubbleBucket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickBubbleBucket.Data
{
    public class ListData
    {
        int row = 20;
        private List<TShirt> _unsortedList;

        public List<TShirt> UnsortedList
        {
            get { return _unsortedList; }
            set { _unsortedList = value; }
        }
        public ListData(int numberOfTShirts)
        {
            SynthData(numberOfTShirts);
            Console.SetCursorPosition(80, row++);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }
        private List<TShirt> SynthData(int numberOfTShirts)
        {
            Console.Clear();
            Console.SetCursorPosition(80, row++);
            Console.WriteLine("Please wait, generating your Data...");
            var _unsortedList = new List<TShirt>();
            for (int i = 0; i < numberOfTShirts; i++)
            {
                Random rnd = new Random();
                int randomColor = rnd.Next(1,7);
                Thread.Sleep(5);
                int randomSize = rnd.Next(1, 7);
                Thread.Sleep(5);
                int randomFabric = rnd.Next(1, 7);
                Thread.Sleep(5);
                _unsortedList.Add(new TShirt((Color)randomColor, (Size)randomSize, (Fabric)randomFabric));
            }
            foreach (var tshirt in _unsortedList)
            {
                Console.SetCursorPosition(80, row);
                tshirt. Stringify(tshirt);
                row++;
            }
            return UnsortedList= _unsortedList;
        }
    }

}
