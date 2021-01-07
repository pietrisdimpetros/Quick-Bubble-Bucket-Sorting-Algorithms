using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickBubbleBucket.BaseSortClass;

namespace QuickBubbleBucket
{
    public static class Initialize
    {
        internal static int _selectedAlgorithm;
        internal static int _selectedMethod;
        internal static int _exit;
        internal static Data.ListData _synthdata;
        public static void TheSoftware()
        {
            do
            {
                //Make Algorith Menu and Select one
                _exit = SelectAlgorithm();
                if (_exit == -1) break;
                _synthdata = Menus.GenerateSynthData();
                SelectMethodOfSorting(_synthdata);
                while (Menus.RunWithSameData() == true)
                    SelectMethodOfSorting(_synthdata);
                //Ask to Run Again
                Menus.RunAgain();
            } while (_exit != -1);
        }
        public static int SelectAlgorithm()
        {

            #region Make the algorithm selection Menu

            _selectedAlgorithm = Menus.SelectionMenu(true, "Which algorithm would you like to use?\nPress escape to exit" +
                "", 3, 15,
                "Quick Sort",
                "Bubble Sort",
                "Bucket Sort");
            #endregion
            //return exit value
            return _selectedAlgorithm;
        }
        public static void SelectMethodOfSorting(Data.ListData listData)
        {
            _selectedMethod = MethodListAndSortedList.ChooseMethod();
            switch (_selectedAlgorithm)
            {
                case 0:
                    new QuickSort(_selectedMethod, listData);
                    break;
                case 1:
                    new BubbleSort(_selectedMethod, listData);
                    break;
                case 2:
                    new BucketSort(_selectedMethod, listData);
                    break;
            }
        }
    }
}
