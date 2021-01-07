using QuickBubbleBucket.BaseSortClass;
using QuickBubbleBucket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBubbleBucket
{
    public class QuickSort : ISort
    {
        public QuickSort(int methodSelection, Data.ListData listData)
        {
            List<TShirt> _unsortedList = listData.UnsortedList;
            Console.Clear();
            int row = 2;
            switch (methodSelection)
            {
                case 0:

                    SortBySizeASC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                case 1:
                    SortBySizeDESC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();

                    break;
                case 2:
                    SortByColorASC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                case 3:
                    SortByColorDESC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                case 4:
                    SortByFabricASC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();

                    break;
                case 5:
                    SortByFabricDESC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                case 6:
                    SortBySizeThenColorThenFabricASC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                case 7:
                    SortBySizeThenColorThenFabricDESC(_unsortedList);
                    foreach (var shirt in _unsortedList)
                    {
                        Console.SetCursorPosition(80, row++);
                        shirt.Stringify(shirt);
                    }
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
        #region Size ASC


        public void SortBySizeASC(List<TShirt> tshirts)
        {
            QuickSortBySizeASC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortBySizeASC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionASC(tshirts, low, high);
                QuickSortBySizeASC(tshirts, low, pi - 1);
                QuickSortBySizeASC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionASC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Size < pivot.Size)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region Size DESC

        public void SortBySizeDESC(List<TShirt> tshirts)
        {
            QuickSortBySizeDESC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortBySizeDESC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortBySizePartitionDESC(tshirts, low, high);
                QuickSortBySizeDESC(tshirts, low, pi - 1);
                QuickSortBySizeDESC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortBySizePartitionDESC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Size > pivot.Size)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region Color ASC


        public void SortByColorASC(List<TShirt> tshirts)
        {
            QuickSortByColorASC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortByColorASC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionASC(tshirts, low, high);
                QuickSortByColorASC(tshirts, low, pi - 1);
                QuickSortByColorASC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionASC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color < pivot.Color)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region Color DESC

        public void SortByColorDESC(List<TShirt> tshirts)
        {
            QuickSortByColorDESC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortByColorDESC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByColorPartitionDESC(tshirts, low, high);
                QuickSortByColorDESC(tshirts, low, pi - 1);
                QuickSortByColorDESC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByColorPartitionDESC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Color > pivot.Color)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region Fabric ASC


        public void SortByFabricASC(List<TShirt> tshirts)
        {
            QuickSortByFabricASC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortByFabricASC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionASC(tshirts, low, high);
                QuickSortByFabricASC(tshirts, low, pi - 1);
                QuickSortByFabricASC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionASC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Fabric < pivot.Fabric)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region Fabric DESC

        public void SortByFabricDESC(List<TShirt> tshirts)
        {
            QuickSortByFabricDESC(tshirts, 0, tshirts.Count - 1);
        }

        static void QuickSortByFabricDESC(List<TShirt> tshirts, int low, int high)
        {
            if (low < high)
            {
                int pi = QuickSortByFabricPartitionDESC(tshirts, low, high);
                QuickSortByFabricDESC(tshirts, low, pi - 1);
                QuickSortByFabricDESC(tshirts, pi + 1, high);
            }
        }

        static int QuickSortByFabricPartitionDESC(List<TShirt> tshirts, int low, int high)
        {
            TShirt pivot = tshirts[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (tshirts[j].Fabric > pivot.Fabric)
                {
                    i++;
                    //swap
                    TShirt temp = tshirts[i];
                    tshirts[i] = tshirts[j];
                    tshirts[j] = temp;
                }
            }
            TShirt temp1 = tshirts[i + 1];
            tshirts[i + 1] = tshirts[high];
            tshirts[high] = temp1;
            return i + 1;
        }
        #endregion

        #region SizeThenColorThenFabric ASC
        public void SortBySizeThenColorThenFabricASC(List<TShirt> tshirts)
        {
            QuickSortBySizeThenColorThenFabricASC(tshirts, 0, tshirts.Count - 1);
        }
        static void QuickSortBySizeThenColorThenFabricASC(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizeThenColorTheFabricPartitionASC(tShirts, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeThenColorThenFabricASC(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricASC(tShirts, pi + 1, high);
            }
        }
        static int QuickSortBySizeThenColorTheFabricPartitionASC(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size < pivot.Size)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color < pivot.Color)
                    {
                        i++;

                        // swap arr[i] and arr[j] 
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        if (tShirts[j].Fabric < pivot.Fabric)
                        {
                            i++;

                            // swap arr[i] and arr[j] 
                            TShirt temp = tShirts[i];
                            tShirts[i] = tShirts[j];
                            tShirts[j] = temp;
                        }
                    }
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;

            return i + 1;
        }
        #endregion

        #region SizeThenColorThenFabric DESC
        public void SortBySizeThenColorThenFabricDESC(List<TShirt> tshirts)
        {
            QuickSortBySizeThenColorThenFabricDESC(tshirts, 0, tshirts.Count - 1);
        }
        static void QuickSortBySizeThenColorThenFabricDESC(List<TShirt> tShirts, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = QuickSortBySizeThenColorTheFabricPartitionDESC(tShirts, low, high);
                // Recursively sort elements before 
                // partition and after partition 
                QuickSortBySizeThenColorThenFabricDESC(tShirts, low, pi - 1);
                QuickSortBySizeThenColorThenFabricDESC(tShirts, pi + 1, high);
            }
        }
        static int QuickSortBySizeThenColorTheFabricPartitionDESC(List<TShirt> tShirts, int low, int high)
        {
            TShirt pivot = tShirts[high];
            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot 
                if (tShirts[j].Size > pivot.Size)
                {
                    i++;
                    // swap arr[i] and arr[j] 
                    TShirt temp = tShirts[i];
                    tShirts[i] = tShirts[j];
                    tShirts[j] = temp;
                }
                else if (tShirts[j].Size == pivot.Size)
                {
                    if (tShirts[j].Color > pivot.Color)
                    {
                        i++;
                        // swap arr[i] and arr[j] 
                        TShirt temp = tShirts[i];
                        tShirts[i] = tShirts[j];
                        tShirts[j] = temp;
                    }
                    else if (tShirts[j].Color == pivot.Color)
                    {
                        if (tShirts[j].Fabric > pivot.Fabric)
                        {
                            i++;
                            // swap arr[i] and arr[j] 
                            TShirt temp = tShirts[i];
                            tShirts[i] = tShirts[j];
                            tShirts[j] = temp;
                        }
                    }
                }
            }
            // swap arr[i+1] and arr[high] (or pivot) 
            TShirt temp1 = tShirts[i + 1];
            tShirts[i + 1] = tShirts[high];
            tShirts[high] = temp1;
            return i + 1;
        }
        #endregion
    }
}
