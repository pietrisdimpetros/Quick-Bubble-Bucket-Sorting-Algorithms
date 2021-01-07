using QuickBubbleBucket.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuickBubbleBucket
{
    public static class Menus
    {
        #region Create Maximized Console, Create Menu options and navigation Menu
        [DllImport("user32.dll")]
        public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
        private static void Maximize()
        {
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3); //SW_MAXIMIZE = 3
        }
        internal static int SelectionMenu(bool canCancel, string introMessage, int optionsPerLine = 3, int spacingPerLine = 15, params string[] options)
        {
            Maximize();
            const int startX = 80;
            const int startY = 20;
            int currentSelection = 0;

            ConsoleKey key;

            Console.CursorVisible = false;

            do
            {
                Console.Clear();
                Console.SetCursorPosition(startX, startY - 1);
                Console.WriteLine(introMessage);
                for (int i = 0; i < options.Length; i++)
                {
                    Console.SetCursorPosition(startX + (i % optionsPerLine) * spacingPerLine, startY + i / optionsPerLine);
                    if (i == currentSelection)
                        Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.Write(options[i]);

                    Console.ResetColor();
                }

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            if (currentSelection % optionsPerLine > 0)
                                currentSelection--;
                            break;
                        }
                    case ConsoleKey.RightArrow:
                        {
                            if (currentSelection % optionsPerLine < optionsPerLine - 1)
                                currentSelection++;
                            break;
                        }
                    case ConsoleKey.UpArrow:
                        {
                            if (currentSelection >= optionsPerLine)
                                currentSelection -= optionsPerLine;
                            break;
                        }
                    case ConsoleKey.DownArrow:
                        {
                            if (currentSelection + optionsPerLine < options.Length)
                                currentSelection += optionsPerLine;
                            break;
                        }
                    case ConsoleKey.Escape:
                        {
                            if (canCancel)
                                return -1;
                            break;
                        }
                }
            } while (key != ConsoleKey.Enter);

            Console.CursorVisible = false;

            return currentSelection;
        }
        internal static object SelectionMenu()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region Generate Synth Data
        public static ListData GenerateSynthData()
        {
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(80, 20);
                Console.WriteLine("How many TShirts would you like to create?");
                Console.SetCursorPosition(80, 21);
                if (Int32.TryParse(Console.ReadLine(), out int _numberOfSynthTShirts) && _numberOfSynthTShirts >= 0)
                {

                    return new ListData(_numberOfSynthTShirts);
                }
                else
                {
                    Console.Clear();
                    Console.SetCursorPosition(80, 20);
                    Console.WriteLine("Wrong Input please give a valid positive number");
                    Console.SetCursorPosition(80, 21);
                    Console.WriteLine("Press any Key");
                    Console.SetCursorPosition(80, 22);
                    Console.ReadLine();
                }
            }
        }
        #endregion
        #region
        internal static bool RunWithSameData()
        {
            
            Console.Clear();
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("Would you like to run another sort with the same Data?");
            Console.SetCursorPosition(80, 21);
            Console.WriteLine("Yes / No");
            Console.SetCursorPosition(80, 22);
            string _runagain = Console.ReadLine().ToLower();
            switch (_runagain)
            {
                case "y":
                case "yes":
                case "yeah":
                    return true;
                case "n":
                case "no":
                    return false;
                default:
                    return false;
            }
        }
        #endregion
        #region Ask to Run Again
        internal static void RunAgain()
        {
            Console.Clear();
            Console.SetCursorPosition(80, 20);
            Console.WriteLine("Would you like to return to the Main Menu?");
            Console.SetCursorPosition(80, 21);
            Console.WriteLine("Yes / No");
            Console.SetCursorPosition(80, 22);
            string _runagain = Console.ReadLine().ToLower();
            switch (_runagain)
            {
                case "y":
                case "yes":
                case "yeah":
                    break;
                case "n":
                case "no":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
