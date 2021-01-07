using QuickBubbleBucket.BaseSortClass;
using QuickBubbleBucket.Models;
using System;
using System.Collections.Generic;

namespace QuickBubbleBucket
{
    public class BubbleSort : ISort
    {
        public BubbleSort(int methodSelection, Data.ListData listData)
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

        public void SortBySizeASC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region Size DESC

        public void SortBySizeDESC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region Color ASC
        public void SortByColorASC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Color > tShirts[j + 1].Color)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }
                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region Color DESC
        public void SortByColorDESC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Color < tShirts[j + 1].Color)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region Fabric ASC

        public void SortByFabricASC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region Fabric DESC
        public void SortByFabricDESC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Fabric < tShirts[j + 1].Fabric)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region SizeThenColorThenFabric ASC
        public void SortBySizeThenColorThenFabricASC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size > tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                    else if (tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if (tShirts[j].Color > tShirts[j + 1].Color)
                        {
                            temp = tShirts[j];
                            tShirts[j] = tShirts[j + 1];
                            tShirts[j + 1] = temp;
                            swapped = true;
                        }
                        else if (tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if (tShirts[j].Fabric > tShirts[j + 1].Fabric)
                            {
                                temp = tShirts[j];
                                tShirts[j] = tShirts[j + 1];
                                tShirts[j + 1] = temp;
                                swapped = true;
                            }
                        }
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion

        #region SizeThenColorThenFabric DESC

        public void SortBySizeThenColorThenFabricDESC(List<TShirt> tShirts)
        {
            int i, j;
            TShirt temp;
            bool swapped;
            for (i = 0; i < tShirts.Count - 1; i++)
            {
                swapped = false;
                for (j = 0; j < tShirts.Count - i - 1; j++)
                {
                    if (tShirts[j].Size < tShirts[j + 1].Size)
                    {
                        // swap arr[j] and arr[j+1] 
                        temp = tShirts[j];
                        tShirts[j] = tShirts[j + 1];
                        tShirts[j + 1] = temp;
                        swapped = true;
                    }
                    else if (tShirts[j].Size == tShirts[j + 1].Size)
                    {
                        if (tShirts[j].Color < tShirts[j + 1].Color)
                        {
                            temp = tShirts[j];
                            tShirts[j] = tShirts[j + 1];
                            tShirts[j + 1] = temp;
                            swapped = true;
                        }
                        else if (tShirts[j].Color == tShirts[j + 1].Color)
                        {
                            if (tShirts[j].Fabric < tShirts[j + 1].Fabric)
                            {
                                temp = tShirts[j];
                                tShirts[j] = tShirts[j + 1];
                                tShirts[j + 1] = temp;
                                swapped = true;
                            }
                        }
                    }
                }

                // IF no two elements were  
                // swapped by inner loop, then break 
                if (swapped == false)
                    break;
            }
        }
        #endregion
    }
}