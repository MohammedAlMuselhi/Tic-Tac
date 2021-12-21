using System;
using System.Threading;

namespace TicTacToe

{
    class Program

    {


        static char[] arr_numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int check = 0;
        static void Main(string[] args)

        {

            Console.WriteLine("\nWelcome to Three-step competition(Tic Tac Toe), please press any to begin");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n\nEnter Your_Name:\n");
            string Your_Name = Console.ReadLine();
            Console.WriteLine("\nFirst player name is " + Your_Name);
            Console.WriteLine("\n\nEnter Your_Name:\n");
            string Your_Namee = Console.ReadLine();
            Console.WriteLine("\n\nThe second player's name is " + Your_Namee);

            do

            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine("                        |");
                Console.WriteLine("                        |");
                Console.WriteLine("                        |");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n" + Your_Name + " (First player) " + "☺\n");
                Console.WriteLine("" + Your_Namee + " (Second player) " + "☼\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                        |");
                Console.WriteLine("                        |");
                Console.WriteLine("                        |");
                Console.WriteLine("-------------------------");
                Console.WriteLine("\n");

                if (player % 2 == 0)


                {

                    Console.WriteLine("                                                          " + Your_Namee + "'s" + " Chance");

                }

                else

                {

                    Console.WriteLine("                                                          " + Your_Name + "'s" + " Chance");

                }

                Console.WriteLine("\n");

                Board();

                choice = int.Parse(Console.ReadLine());

                if (arr_numbers[choice] != '☺' && arr_numbers[choice] != '☼')

                {

                    if (player % 2 == 0)

                    {

                        arr_numbers[choice] = '☼';

                        player++;

                    }

                    else

                    {

                        arr_numbers[choice] = '☺';

                        player++;

                    }

                }

                else

                {

                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr_numbers[choice]);

                    Console.WriteLine("\n");

                    Console.WriteLine("Please wait 1 second.....");

                    Thread.Sleep(1000);

                }

                check = CheckWin();

            } while (check != 1 && check != -1);



            Console.Clear();

            Board();
            if (check == 1)

            {

                Console.WriteLine("Player {0}", (player % 2) + 1);
                Console.WriteLine("\n");
                {
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("                                     ÛÛÛ    ÛÛÛ    ÛÛÛ                          ");
                    Console.WriteLine("                                     ÛÛÛ    ÛÛÛ    ÛÛÛ   ÛÛÛÛÛÛ  ÛÛÛÛÛÛÛÛ   ");
                    Console.WriteLine("                                     ÛÛÛ    ÛÛÛ    ÛÛÛ  ÛÛÛ  ÛÛÛ  ÛÛÛ  ÛÛÛ     ");
                    Console.WriteLine("                                      ÛÛÛ  ÛÛÛÛÛ  ÛÛÛ   ÛÛÛ  ÛÛÛ  ÛÛÛ  ÛÛÛ      ");
                    Console.WriteLine("                                        ÛÛÛÛÛ ÛÛÛÛÛ     ÛÛÛ  ÛÛÛ  ÛÛÛ  ÛÛÛ       ");
                    Console.WriteLine("                                          ÛÛÛ ÛÛÛ       ÛÛÛÛÛÛ  ÛÛÛÛ ÛÛÛÛÛ     ");

                    Console.ResetColor();
                }

            }

            else

            {

                Console.WriteLine("Draw");

            }

            Console.ReadLine();

        }
        private static void Board()

        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                    -------------------------");
            Console.WriteLine("                                                    |       |       |       |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                    |   {0}   |   {1}   |   {2}   |", arr_numbers[1], arr_numbers[2], arr_numbers[3]);
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    -------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("                                                    |       |       |       |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                    |   {0}   |   {1}   |   {2}   |", arr_numbers[4], arr_numbers[5], arr_numbers[6]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    -------------------------");
            Console.WriteLine("                                                    |       |       |       |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                    |   {0}   |   {1}   |   {2}   |", arr_numbers[7], arr_numbers[8], arr_numbers[9]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    |       |       |       |");
            Console.WriteLine("                                                    -------------------------");
        }

        private static int CheckWin()

        {
            #region Horzontal Winning Condtion

            if (arr_numbers[1] == arr_numbers[2] && arr_numbers[2] == arr_numbers[3])

            {

                return 1;

            }

            else if (arr_numbers[4] == arr_numbers[5] && arr_numbers[5] == arr_numbers[6])

            {

                return 1;

            }


            else if (arr_numbers[6] == arr_numbers[7] && arr_numbers[7] == arr_numbers[8])

            {

                return 1;

            }

            #endregion

            #region vertical Winning Condtion

            else if (arr_numbers[1] == arr_numbers[4] && arr_numbers[4] == arr_numbers[7])

            {

                return 1;

            }

            else if (arr_numbers[2] == arr_numbers[5] && arr_numbers[5] == arr_numbers[8])

            {

                return 1;

            }


            else if (arr_numbers[3] == arr_numbers[6] && arr_numbers[6] == arr_numbers[9])

            {

                return 1;

            }

            #endregion

            #region Diagonal Winning Condition

            else if (arr_numbers[1] == arr_numbers[5] && arr_numbers[5] == arr_numbers[9])

            {

                return 1;

            }

            else if (arr_numbers[3] == arr_numbers[5] && arr_numbers[5] == arr_numbers[7])

            {

                return 1;

            }

            #endregion

            #region Checking For Draw

            else if (arr_numbers[1] != '1' && arr_numbers[2] != '2' && arr_numbers[3] != '3' && arr_numbers[4] != '4' && arr_numbers[5] != '5' && arr_numbers[6] != '6' && arr_numbers[7] != '7' && arr_numbers[8] != '8' && arr_numbers[9] != '9')

            {

                return -1;

            }

            #endregion

            else

            {

                return 0;

            }

        }

    }

}