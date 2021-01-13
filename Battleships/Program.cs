using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships9
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            //2D array for player 1 ships
            string[,] player1 = new string[,]
            {
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
            };

            //2D array for player 2 ships
            string[,] player2 = new string[,]
            {
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
            };

            //2D array for player 1 hits
            string[,] hitPlayer1 = new string[,]
            {
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
            };

            //2D array for player 2 hits
            string[,] hitPlayer2 = new string[,]
            {
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
                {"-", "-", "-","-","-","-", "-", "-","-","-"},
            };

            //Creates player 1's ships board
            Console.WriteLine("    | a | b | c | d | e | f | g | h | i | j |");
            Console.WriteLine("| 1 | " + player1[0, 0] + " | " + player1[0, 1] + " | " + player1[0, 2] + " | " + player1[0, 3] + " | " + player1[0, 4] + " | " + player1[0, 5] + " | " + player1[0, 6] + " | " + player1[0, 7] + " | " + player1[0, 8] + " | " + player1[0, 9] + " | ");
            Console.WriteLine("| 2 | " + player1[1, 0] + " | " + player1[1, 1] + " | " + player1[1, 2] + " | " + player1[1, 3] + " | " + player1[1, 4] + " | " + player1[1, 5] + " | " + player1[1, 6] + " | " + player1[1, 7] + " | " + player1[1, 8] + " | " + player1[1, 9] + " | ");
            Console.WriteLine("| 3 | " + player1[2, 0] + " | " + player1[2, 1] + " | " + player1[2, 2] + " | " + player1[2, 3] + " | " + player1[2, 4] + " | " + player1[2, 5] + " | " + player1[2, 6] + " | " + player1[2, 7] + " | " + player1[2, 8] + " | " + player1[2, 9] + " | ");
            Console.WriteLine("| 4 | " + player1[3, 0] + " | " + player1[3, 1] + " | " + player1[3, 2] + " | " + player1[3, 3] + " | " + player1[3, 4] + " | " + player1[3, 5] + " | " + player1[3, 6] + " | " + player1[3, 7] + " | " + player1[3, 8] + " | " + player1[3, 9] + " | ");
            Console.WriteLine("| 5 | " + player1[4, 0] + " | " + player1[4, 1] + " | " + player1[4, 2] + " | " + player1[4, 3] + " | " + player1[4, 4] + " | " + player1[4, 5] + " | " + player1[4, 6] + " | " + player1[4, 7] + " | " + player1[4, 8] + " | " + player1[4, 9] + " | ");
            Console.WriteLine("| 6 | " + player1[5, 0] + " | " + player1[5, 1] + " | " + player1[5, 2] + " | " + player1[5, 3] + " | " + player1[5, 4] + " | " + player1[5, 5] + " | " + player1[5, 6] + " | " + player1[5, 7] + " | " + player1[5, 8] + " | " + player1[5, 9] + " | ");
            Console.WriteLine("| 7 | " + player1[6, 0] + " | " + player1[6, 1] + " | " + player1[6, 2] + " | " + player1[6, 3] + " | " + player1[6, 4] + " | " + player1[6, 5] + " | " + player1[6, 6] + " | " + player1[6, 7] + " | " + player1[6, 8] + " | " + player1[6, 9] + " | ");
            Console.WriteLine("| 8 | " + player1[7, 0] + " | " + player1[7, 1] + " | " + player1[7, 2] + " | " + player1[7, 3] + " | " + player1[7, 4] + " | " + player1[7, 5] + " | " + player1[7, 6] + " | " + player1[7, 7] + " | " + player1[7, 8] + " | " + player1[7, 9] + " | ");
            Console.WriteLine("| 9 | " + player1[8, 0] + " | " + player1[8, 1] + " | " + player1[8, 2] + " | " + player1[8, 3] + " | " + player1[8, 4] + " | " + player1[8, 5] + " | " + player1[8, 6] + " | " + player1[8, 7] + " | " + player1[8, 8] + " | " + player1[8, 9] + " | ");
            Console.WriteLine("| 10| " + player1[9, 0] + " | " + player1[9, 1] + " | " + player1[9, 2] + " | " + player1[9, 3] + " | " + player1[9, 4] + " | " + player1[9, 5] + " | " + player1[9, 6] + " | " + player1[9, 7] + " | " + player1[9, 8] + " | " + player1[9, 9] + " | ");
            //count control loop
            //loops 7 times to obtain the coordinates of 7 different ships for player 1
            for (int ships = 0; ships < 7; ships++)
            {

                Console.WriteLine("Player 1: Please enter the x coordinate for where you want to place your ship?");
                string shipPlacementx = Console.ReadLine();
                //creates a condition loop to manipulate the string given by player 1
                bool validAnswer = true;
                while (validAnswer == true)
                {
                    if (shipPlacementx == "a") //checks the character the player gives
                    {
                        shipPlacementx = "0"; //converts the character to an integer that the program can understand
                    }

                    else if (shipPlacementx == "b")
                    {
                        shipPlacementx = "1";
                    }

                    else if (shipPlacementx == "c")
                    {
                        shipPlacementx = "2";
                    }

                    else if (shipPlacementx == "d")
                    {
                        shipPlacementx = "3";
                    }

                    else if (shipPlacementx == "e")
                    {
                        shipPlacementx = "4";
                    }

                    else if (shipPlacementx == "f")
                    {
                        shipPlacementx = "5";
                    }

                    else if (shipPlacementx == "g")
                    {
                        shipPlacementx = "6";
                    }

                    else if (shipPlacementx == "h")
                    {
                        shipPlacementx = "7";
                    }

                    else if (shipPlacementx == "i")
                    {
                        shipPlacementx = "8";
                    }

                    else if (shipPlacementx == "j")
                    {
                        shipPlacementx = "9";
                    }

                    else
                    {
                        //creates a condition if player 1 has entered an invalid character, loops round the validAnswer condition loop
                        Console.WriteLine("Please enter a letter from a-j");
                        shipPlacementx = Console.ReadLine();
                        validAnswer = true;
                        Console.WriteLine(shipPlacementx);
                        Console.ReadLine();
                    }

                    //converts the character that was just converted into an integer so the program can find its cell in the array
                    int xcord = Convert.ToInt32(shipPlacementx);
                    Console.WriteLine("Player 1: Please enter the y coordinate for where you want to place your ship?");
                    int shipPlacementy = Convert.ToInt32(Console.ReadLine());
                    if (shipPlacementy >= 11) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        shipPlacementy = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (shipPlacementy <= 0) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        shipPlacementy = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        //updates the 2D array of player 1's ships
                        shipPlacementy = shipPlacementy - 1;
                        player1[shipPlacementy, xcord] = "x";

                        Console.Clear();
                        //creates player 1's board for the user
                        Console.WriteLine("    | a | b | c | d | e | f | g | h | i | j |");
                        Console.WriteLine("| 1 | " + player1[0, 0] + " | " + player1[0, 1] + " | " + player1[0, 2] + " | " + player1[0, 3] + " | " + player1[0, 4] + " | " + player1[0, 5] + " | " + player1[0, 6] + " | " + player1[0, 7] + " | " + player1[0, 8] + " | " + player1[0, 9] + " | ");
                        Console.WriteLine("| 2 | " + player1[1, 0] + " | " + player1[1, 1] + " | " + player1[1, 2] + " | " + player1[1, 3] + " | " + player1[1, 4] + " | " + player1[1, 5] + " | " + player1[1, 6] + " | " + player1[1, 7] + " | " + player1[1, 8] + " | " + player1[1, 9] + " | ");
                        Console.WriteLine("| 3 | " + player1[2, 0] + " | " + player1[2, 1] + " | " + player1[2, 2] + " | " + player1[2, 3] + " | " + player1[2, 4] + " | " + player1[2, 5] + " | " + player1[2, 6] + " | " + player1[2, 7] + " | " + player1[2, 8] + " | " + player1[2, 9] + " | ");
                        Console.WriteLine("| 4 | " + player1[3, 0] + " | " + player1[3, 1] + " | " + player1[3, 2] + " | " + player1[3, 3] + " | " + player1[3, 4] + " | " + player1[3, 5] + " | " + player1[3, 6] + " | " + player1[3, 7] + " | " + player1[3, 8] + " | " + player1[3, 9] + " | ");
                        Console.WriteLine("| 5 | " + player1[4, 0] + " | " + player1[4, 1] + " | " + player1[4, 2] + " | " + player1[4, 3] + " | " + player1[4, 4] + " | " + player1[4, 5] + " | " + player1[4, 6] + " | " + player1[4, 7] + " | " + player1[4, 8] + " | " + player1[4, 9] + " | ");
                        Console.WriteLine("| 6 | " + player1[5, 0] + " | " + player1[5, 1] + " | " + player1[5, 2] + " | " + player1[5, 3] + " | " + player1[5, 4] + " | " + player1[5, 5] + " | " + player1[5, 6] + " | " + player1[5, 7] + " | " + player1[5, 8] + " | " + player1[5, 9] + " | ");
                        Console.WriteLine("| 7 | " + player1[6, 0] + " | " + player1[6, 1] + " | " + player1[6, 2] + " | " + player1[6, 3] + " | " + player1[6, 4] + " | " + player1[6, 5] + " | " + player1[6, 6] + " | " + player1[6, 7] + " | " + player1[6, 8] + " | " + player1[6, 9] + " | ");
                        Console.WriteLine("| 8 | " + player1[7, 0] + " | " + player1[7, 1] + " | " + player1[7, 2] + " | " + player1[7, 3] + " | " + player1[7, 4] + " | " + player1[7, 5] + " | " + player1[7, 6] + " | " + player1[7, 7] + " | " + player1[7, 8] + " | " + player1[7, 9] + " | ");
                        Console.WriteLine("| 9 | " + player1[8, 0] + " | " + player1[8, 1] + " | " + player1[8, 2] + " | " + player1[8, 3] + " | " + player1[8, 4] + " | " + player1[8, 5] + " | " + player1[8, 6] + " | " + player1[8, 7] + " | " + player1[8, 8] + " | " + player1[8, 9] + " | ");
                        Console.WriteLine("| 10| " + player1[9, 0] + " | " + player1[9, 1] + " | " + player1[9, 2] + " | " + player1[9, 3] + " | " + player1[9, 4] + " | " + player1[9, 5] + " | " + player1[9, 6] + " | " + player1[9, 7] + " | " + player1[9, 8] + " | " + player1[9, 9] + " | ");
                        validAnswer = false;
                    }
                }
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            //Creates player 2's ships board
            Console.WriteLine("    | a | b | c | d | e | f | g | h | i | j |");
            Console.WriteLine("| 1 | " + player2[0, 0] + " | " + player2[0, 1] + " | " + player2[0, 2] + " | " + player2[0, 3] + " | " + player2[0, 4] + " | " + player2[0, 5] + " | " + player2[0, 6] + " | " + player2[0, 7] + " | " + player2[0, 8] + " | " + player2[0, 9] + " | ");
            Console.WriteLine("| 2 | " + player2[1, 0] + " | " + player2[1, 1] + " | " + player2[1, 2] + " | " + player2[1, 3] + " | " + player2[1, 4] + " | " + player2[1, 5] + " | " + player2[1, 6] + " | " + player2[1, 7] + " | " + player2[1, 8] + " | " + player2[1, 9] + " | ");
            Console.WriteLine("| 3 | " + player2[2, 0] + " | " + player2[2, 1] + " | " + player2[2, 2] + " | " + player2[2, 3] + " | " + player2[2, 4] + " | " + player2[2, 5] + " | " + player2[2, 6] + " | " + player2[2, 7] + " | " + player2[2, 8] + " | " + player2[2, 9] + " | ");
            Console.WriteLine("| 4 | " + player2[3, 0] + " | " + player2[3, 1] + " | " + player2[3, 2] + " | " + player2[3, 3] + " | " + player2[3, 4] + " | " + player2[3, 5] + " | " + player2[3, 6] + " | " + player2[3, 7] + " | " + player2[3, 8] + " | " + player2[3, 9] + " | ");
            Console.WriteLine("| 5 | " + player2[4, 0] + " | " + player2[4, 1] + " | " + player2[4, 2] + " | " + player2[4, 3] + " | " + player2[4, 4] + " | " + player2[4, 5] + " | " + player2[4, 6] + " | " + player2[4, 7] + " | " + player2[4, 8] + " | " + player2[4, 9] + " | ");
            Console.WriteLine("| 6 | " + player2[5, 0] + " | " + player2[5, 1] + " | " + player2[5, 2] + " | " + player2[5, 3] + " | " + player2[5, 4] + " | " + player2[5, 5] + " | " + player2[5, 6] + " | " + player2[5, 7] + " | " + player2[5, 8] + " | " + player2[5, 9] + " | ");
            Console.WriteLine("| 7 | " + player2[6, 0] + " | " + player2[6, 1] + " | " + player2[6, 2] + " | " + player2[6, 3] + " | " + player2[6, 4] + " | " + player2[6, 5] + " | " + player2[6, 6] + " | " + player2[6, 7] + " | " + player2[6, 8] + " | " + player2[6, 9] + " | ");
            Console.WriteLine("| 8 | " + player2[7, 0] + " | " + player2[7, 1] + " | " + player2[7, 2] + " | " + player2[7, 3] + " | " + player2[7, 4] + " | " + player2[7, 5] + " | " + player2[7, 6] + " | " + player2[7, 7] + " | " + player2[7, 8] + " | " + player2[7, 9] + " | ");
            Console.WriteLine("| 9 | " + player2[8, 0] + " | " + player2[8, 1] + " | " + player2[8, 2] + " | " + player2[8, 3] + " | " + player2[8, 4] + " | " + player2[8, 5] + " | " + player2[8, 6] + " | " + player2[8, 7] + " | " + player2[8, 8] + " | " + player2[8, 9] + " | ");
            Console.WriteLine("| 10| " + player2[9, 0] + " | " + player2[9, 1] + " | " + player2[9, 2] + " | " + player2[9, 3] + " | " + player2[9, 4] + " | " + player2[9, 5] + " | " + player2[9, 6] + " | " + player2[9, 7] + " | " + player2[9, 8] + " | " + player2[9, 9] + " | ");
            //creates a condition loop to manipulate the string given by player 2
            bool validAnswer2 = true;
            while (validAnswer2 == true)
            {
                //count control loop
                //loops 7 times to obtain the coordinates of 7 different ships for player 2
                for (int shipsPlayer2 = 0; shipsPlayer2 < 7; shipsPlayer2++)
                {
                    Console.WriteLine("Player 2: Please enter the x coordinate for where you want to place your ship?");
                    string shipPlacementx2 = Console.ReadLine();
                    if (shipPlacementx2 == "a") //checks the character the player gives
                    {
                        shipPlacementx2 = "0"; //converts the character to an integer that the program can understand
                    }

                    else if (shipPlacementx2 == "b")
                    {
                        shipPlacementx2 = "1";
                    }

                    else if (shipPlacementx2 == "c")
                    {
                        shipPlacementx2 = "2";
                    }

                    else if (shipPlacementx2 == "d")
                    {
                        shipPlacementx2 = "3";
                    }

                    else if (shipPlacementx2 == "e")
                    {
                        shipPlacementx2 = "4";
                    }

                    else if (shipPlacementx2 == "f")
                    {
                        shipPlacementx2 = "5";
                    }

                    else if (shipPlacementx2 == "g")
                    {
                        shipPlacementx2 = "6";
                    }

                    else if (shipPlacementx2 == "h")
                    {
                        shipPlacementx2 = "7";
                    }

                    else if (shipPlacementx2 == "i")
                    {
                        shipPlacementx2 = "8";
                    }

                    else if (shipPlacementx2 == "j")
                    {
                        shipPlacementx2 = "9";
                    }

                    else
                    {
                        //creates a condition if player 1 has entered an invalid character, loops round the validAnswer condition loop
                        Console.WriteLine("Please enter a letter from a-j");
                        validAnswer2 = true;
                    }

                    //converts the character that was just converted into an integer so the program can find its cell in the array
                    int xcord2 = Convert.ToInt32(shipPlacementx2);
                    Console.WriteLine("Player 2: Please enter the y coordinate for where you want to place your ship?");
                    int shipPlacementy2 = Convert.ToInt32(Console.ReadLine());
                    if (shipPlacementy2 > 11) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        shipPlacementy2 = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (shipPlacementy2 < 0) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        shipPlacementy2 = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        //updates the 2D array of player 2's ships
                        shipPlacementy2 = shipPlacementy2 - 1;
                        player2[shipPlacementy2, xcord2] = "x";
                    }

                    //creates player 2's board for the user
                    Console.Clear();
                    Console.WriteLine("    | a | b | c | d | e | f | g | h | i | j |");
                    Console.WriteLine("| 1 | " + player2[0, 0] + " | " + player2[0, 1] + " | " + player2[0, 2] + " | " + player2[0, 3] + " | " + player2[0, 4] + " | " + player2[0, 5] + " | " + player2[0, 6] + " | " + player2[0, 7] + " | " + player2[0, 8] + " | " + player2[0, 9] + " | ");
                    Console.WriteLine("| 2 | " + player2[1, 0] + " | " + player2[1, 1] + " | " + player2[1, 2] + " | " + player2[1, 3] + " | " + player2[1, 4] + " | " + player2[1, 5] + " | " + player2[1, 6] + " | " + player2[1, 7] + " | " + player2[1, 8] + " | " + player2[1, 9] + " | ");
                    Console.WriteLine("| 3 | " + player2[2, 0] + " | " + player2[2, 1] + " | " + player2[2, 2] + " | " + player2[2, 3] + " | " + player2[2, 4] + " | " + player2[2, 5] + " | " + player2[2, 6] + " | " + player2[2, 7] + " | " + player2[2, 8] + " | " + player2[2, 9] + " | ");
                    Console.WriteLine("| 4 | " + player2[3, 0] + " | " + player2[3, 1] + " | " + player2[3, 2] + " | " + player2[3, 3] + " | " + player2[3, 4] + " | " + player2[3, 5] + " | " + player2[3, 6] + " | " + player2[3, 7] + " | " + player2[3, 8] + " | " + player2[3, 9] + " | ");
                    Console.WriteLine("| 5 | " + player2[4, 0] + " | " + player2[4, 1] + " | " + player2[4, 2] + " | " + player2[4, 3] + " | " + player2[4, 4] + " | " + player2[4, 5] + " | " + player2[4, 6] + " | " + player2[4, 7] + " | " + player2[4, 8] + " | " + player2[4, 9] + " | ");
                    Console.WriteLine("| 6 | " + player2[5, 0] + " | " + player2[5, 1] + " | " + player2[5, 2] + " | " + player2[5, 3] + " | " + player2[5, 4] + " | " + player2[5, 5] + " | " + player2[5, 6] + " | " + player2[5, 7] + " | " + player2[5, 8] + " | " + player2[5, 9] + " | ");
                    Console.WriteLine("| 7 | " + player2[6, 0] + " | " + player2[6, 1] + " | " + player2[6, 2] + " | " + player2[6, 3] + " | " + player2[6, 4] + " | " + player2[6, 5] + " | " + player2[6, 6] + " | " + player2[6, 7] + " | " + player2[6, 8] + " | " + player2[6, 9] + " | ");
                    Console.WriteLine("| 8 | " + player2[7, 0] + " | " + player2[7, 1] + " | " + player2[7, 2] + " | " + player2[7, 3] + " | " + player2[7, 4] + " | " + player2[7, 5] + " | " + player2[7, 6] + " | " + player2[7, 7] + " | " + player2[7, 8] + " | " + player2[7, 9] + " | ");
                    Console.WriteLine("| 9 | " + player2[8, 0] + " | " + player2[8, 1] + " | " + player2[8, 2] + " | " + player2[8, 3] + " | " + player2[8, 4] + " | " + player2[8, 5] + " | " + player2[8, 6] + " | " + player2[8, 7] + " | " + player2[8, 8] + " | " + player2[8, 9] + " | ");
                    Console.WriteLine("| 10| " + player2[9, 0] + " | " + player2[9, 1] + " | " + player2[9, 2] + " | " + player2[9, 3] + " | " + player2[9, 4] + " | " + player2[9, 5] + " | " + player2[9, 6] + " | " + player2[9, 7] + " | " + player2[9, 8] + " | " + player2[9, 9] + " | ");
                    validAnswer2 = false;
                }
            }

            bool canContinue = true;
            while (canContinue)
            {
                //creates player 1's and player 2's board for the users
                Console.Clear();
                Console.WriteLine("Player 1 hit attempts        Player 2 hit attempts");
                Console.WriteLine("    | a | b | c | d | e | f | g | h | i | j |       | a | b | c | d | e | f | g | h | i | j |");
                Console.WriteLine("| 1 | " + hitPlayer1[0, 0] + " | " + hitPlayer1[0, 1] + " | " + hitPlayer1[0, 2] + " | " + hitPlayer1[0, 3] + " | " + hitPlayer1[0, 4] + " | " + hitPlayer1[0, 5] + " | " + hitPlayer1[0, 6] + " | " + hitPlayer1[0, 7] + " | " + hitPlayer1[0, 8] + " | " + hitPlayer1[0, 9] + " |      " + hitPlayer2[0, 0] + " | " + hitPlayer2[0, 1] + " | " + hitPlayer2[0, 2] + " | " + hitPlayer2[0, 3] + " | " + hitPlayer2[0, 4] + " | " + hitPlayer2[0, 5] + " | " + hitPlayer2[0, 6] + " | " + hitPlayer2[0, 7] + " | " + hitPlayer2[0, 8] + " | " + hitPlayer2[0, 9] + " | ");
                Console.WriteLine("| 2 | " + hitPlayer1[1, 0] + " | " + hitPlayer1[1, 1] + " | " + hitPlayer1[1, 2] + " | " + hitPlayer1[1, 3] + " | " + hitPlayer1[1, 4] + " | " + hitPlayer1[1, 5] + " | " + hitPlayer1[1, 6] + " | " + hitPlayer1[1, 7] + " | " + hitPlayer1[1, 8] + " | " + hitPlayer1[1, 9] + " |      " + hitPlayer2[1, 0] + " | " + hitPlayer2[1, 1] + " | " + hitPlayer2[1, 2] + " | " + hitPlayer2[1, 3] + " | " + hitPlayer2[1, 4] + " | " + hitPlayer2[1, 5] + " | " + hitPlayer2[1, 6] + " | " + hitPlayer2[1, 7] + " | " + hitPlayer2[1, 8] + " | " + hitPlayer2[1, 9] + " | ");
                Console.WriteLine("| 3 | " + hitPlayer1[2, 0] + " | " + hitPlayer1[2, 1] + " | " + hitPlayer1[2, 2] + " | " + hitPlayer1[2, 3] + " | " + hitPlayer1[2, 4] + " | " + hitPlayer1[2, 5] + " | " + hitPlayer1[2, 6] + " | " + hitPlayer1[2, 7] + " | " + hitPlayer1[2, 8] + " | " + hitPlayer1[2, 9] + " |      " + hitPlayer2[2, 0] + " | " + hitPlayer2[2, 1] + " | " + hitPlayer2[2, 2] + " | " + hitPlayer2[2, 3] + " | " + hitPlayer2[2, 4] + " | " + hitPlayer2[2, 5] + " | " + hitPlayer2[2, 6] + " | " + hitPlayer2[2, 7] + " | " + hitPlayer2[2, 8] + " | " + hitPlayer2[2, 9] + " | ");
                Console.WriteLine("| 4 | " + hitPlayer1[3, 0] + " | " + hitPlayer1[3, 1] + " | " + hitPlayer1[3, 2] + " | " + hitPlayer1[3, 3] + " | " + hitPlayer1[3, 4] + " | " + hitPlayer1[3, 5] + " | " + hitPlayer1[3, 6] + " | " + hitPlayer1[3, 7] + " | " + hitPlayer1[3, 8] + " | " + hitPlayer1[3, 9] + " |      " + hitPlayer2[3, 0] + " | " + hitPlayer2[3, 1] + " | " + hitPlayer2[3, 2] + " | " + hitPlayer2[3, 3] + " | " + hitPlayer2[3, 4] + " | " + hitPlayer2[3, 5] + " | " + hitPlayer2[3, 6] + " | " + hitPlayer2[3, 7] + " | " + hitPlayer2[3, 8] + " | " + hitPlayer2[3, 9] + " | ");
                Console.WriteLine("| 5 | " + hitPlayer1[4, 0] + " | " + hitPlayer1[4, 1] + " | " + hitPlayer1[4, 2] + " | " + hitPlayer1[4, 3] + " | " + hitPlayer1[4, 4] + " | " + hitPlayer1[4, 5] + " | " + hitPlayer1[4, 6] + " | " + hitPlayer1[4, 7] + " | " + hitPlayer1[4, 8] + " | " + hitPlayer1[4, 9] + " |      " + hitPlayer2[4, 0] + " | " + hitPlayer2[4, 1] + " | " + hitPlayer2[4, 2] + " | " + hitPlayer2[4, 3] + " | " + hitPlayer2[4, 4] + " | " + hitPlayer2[4, 5] + " | " + hitPlayer2[4, 6] + " | " + hitPlayer2[4, 7] + " | " + hitPlayer2[4, 8] + " | " + hitPlayer2[4, 9] + " | ");
                Console.WriteLine("| 6 | " + hitPlayer1[5, 0] + " | " + hitPlayer1[5, 1] + " | " + hitPlayer1[5, 2] + " | " + hitPlayer1[5, 3] + " | " + hitPlayer1[5, 4] + " | " + hitPlayer1[5, 5] + " | " + hitPlayer1[5, 6] + " | " + hitPlayer1[5, 7] + " | " + hitPlayer1[5, 8] + " | " + hitPlayer1[5, 9] + " |      " + hitPlayer2[5, 0] + " | " + hitPlayer2[5, 1] + " | " + hitPlayer2[5, 2] + " | " + hitPlayer2[5, 3] + " | " + hitPlayer2[5, 4] + " | " + hitPlayer2[5, 5] + " | " + hitPlayer2[5, 6] + " | " + hitPlayer2[5, 7] + " | " + hitPlayer2[5, 8] + " | " + hitPlayer2[5, 9] + " | ");
                Console.WriteLine("| 7 | " + hitPlayer1[6, 0] + " | " + hitPlayer1[6, 1] + " | " + hitPlayer1[6, 2] + " | " + hitPlayer1[6, 3] + " | " + hitPlayer1[6, 4] + " | " + hitPlayer1[6, 5] + " | " + hitPlayer1[6, 6] + " | " + hitPlayer1[6, 7] + " | " + hitPlayer1[6, 8] + " | " + hitPlayer1[6, 9] + " |      " + hitPlayer2[6, 0] + " | " + hitPlayer2[6, 1] + " | " + hitPlayer2[6, 2] + " | " + hitPlayer2[6, 3] + " | " + hitPlayer2[6, 4] + " | " + hitPlayer2[6, 5] + " | " + hitPlayer2[6, 6] + " | " + hitPlayer2[6, 7] + " | " + hitPlayer2[6, 8] + " | " + hitPlayer2[6, 9] + " | ");
                Console.WriteLine("| 8 | " + hitPlayer1[7, 0] + " | " + hitPlayer1[7, 1] + " | " + hitPlayer1[7, 2] + " | " + hitPlayer1[7, 3] + " | " + hitPlayer1[7, 4] + " | " + hitPlayer1[7, 5] + " | " + hitPlayer1[7, 6] + " | " + hitPlayer1[7, 7] + " | " + hitPlayer1[7, 8] + " | " + hitPlayer1[7, 9] + " |      " + hitPlayer2[7, 0] + " | " + hitPlayer2[7, 1] + " | " + hitPlayer2[7, 2] + " | " + hitPlayer2[7, 3] + " | " + hitPlayer2[7, 4] + " | " + hitPlayer2[7, 5] + " | " + hitPlayer2[7, 6] + " | " + hitPlayer2[7, 7] + " | " + hitPlayer2[7, 8] + " | " + hitPlayer2[7, 9] + " | ");
                Console.WriteLine("| 9 | " + hitPlayer1[8, 0] + " | " + hitPlayer1[8, 1] + " | " + hitPlayer1[8, 2] + " | " + hitPlayer1[8, 3] + " | " + hitPlayer1[8, 4] + " | " + hitPlayer1[8, 5] + " | " + hitPlayer1[8, 6] + " | " + hitPlayer1[8, 7] + " | " + hitPlayer1[8, 8] + " | " + hitPlayer1[8, 9] + " |      " + hitPlayer2[8, 0] + " | " + hitPlayer2[8, 1] + " | " + hitPlayer2[8, 2] + " | " + hitPlayer2[8, 3] + " | " + hitPlayer2[8, 4] + " | " + hitPlayer2[8, 5] + " | " + hitPlayer2[8, 6] + " | " + hitPlayer2[8, 7] + " | " + hitPlayer2[8, 8] + " | " + hitPlayer2[8, 9] + " | ");
                Console.WriteLine("| 10| " + hitPlayer1[9, 0] + " | " + hitPlayer1[9, 1] + " | " + hitPlayer1[9, 2] + " | " + hitPlayer1[9, 3] + " | " + hitPlayer1[9, 4] + " | " + hitPlayer1[9, 5] + " | " + hitPlayer1[9, 6] + " | " + hitPlayer1[9, 7] + " | " + hitPlayer1[9, 8] + " | " + hitPlayer1[9, 9] + " |      " + hitPlayer2[9, 0] + " | " + hitPlayer2[9, 1] + " | " + hitPlayer2[9, 2] + " | " + hitPlayer2[9, 3] + " | " + hitPlayer2[9, 4] + " | " + hitPlayer2[9, 5] + " | " + hitPlayer2[9, 6] + " | " + hitPlayer2[9, 7] + " | " + hitPlayer2[9, 8] + " | " + hitPlayer2[9, 9] + " | ");
                bool validAnswer3 = true;
                while (validAnswer3 == true)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Player 1: Please enter the x coordinate for where you want to hit?");
                    string hitPlacementx = Console.ReadLine();
                    if (hitPlacementx == "a") //checks the character the player gives
                    {
                        hitPlacementx = "0"; //converts the character to an integer that the program can understand
                    }

                    else if (hitPlacementx == "b")
                    {
                        hitPlacementx = "1";
                    }

                    else if (hitPlacementx == "c")
                    {
                        hitPlacementx = "2";
                    }

                    else if (hitPlacementx == "d")
                    {
                        hitPlacementx = "3";
                    }

                    else if (hitPlacementx == "e")
                    {
                        hitPlacementx = "4";
                    }

                    else if (hitPlacementx == "f")
                    {
                        hitPlacementx = "5";
                    }

                    else if (hitPlacementx == "g")
                    {
                        hitPlacementx = "6";
                    }

                    else if (hitPlacementx == "h")
                    {
                        hitPlacementx = "7";
                    }

                    else if (hitPlacementx == "i")
                    {
                        hitPlacementx = "8";
                    }

                    else if (hitPlacementx == "j")
                    {
                        hitPlacementx = "9";
                    }

                    else
                    {
                        //creates a condition if player 1 has entered an invalid character, loops round the validAnswer condition loop
                        Console.WriteLine("Please enter a letter from a-j");
                        validAnswer3 = true;
                    }
                    //converts the character that was just converted into an integer so the program can find its cell in the array
                    int hitxcord = Convert.ToInt32(hitPlacementx);
                    Console.WriteLine("Player 1: Please enter the y coordinate for where you want to hit?");
                    int hitPlacementy = Convert.ToInt32(Console.ReadLine());
                    if (hitPlacementy > 11) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        hitPlacementy = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (hitPlacementy < 0) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        hitPlacementy = Convert.ToInt32(Console.ReadLine());
                    }

                    else
                    {
                        //updates the 2D array of player 1's hits
                        hitPlacementy = hitPlacementy - 1;
                    }

                    if (player2[hitPlacementy, hitxcord] == "x") //checks if the user's "hit" is correct
                    {
                        hitPlayer1[hitPlacementy, hitxcord] = "o"; //updates the array from x to c
                        Console.WriteLine("Entered correct hit");
                        var hitships = hitPlayer1.Length; //checks array length to start a count control loop
                        Console.WriteLine(hitships);
                        //creates a count control loop for the length of the array
                        for (int winnerCheck = 0; winnerCheck < hitships; winnerCheck++)
                        {
                            if (hitPlayer1[winnerCheck, winnerCheck] == "o") //finds the arrays that have a hit "o"
                            {
                                //if it has a correct hit then it adds to the amountOfHits
                                int amountOfHits = 0;
                                amountOfHits = amountOfHits + 1;
                                Console.WriteLine(amountOfHits);
                                if (amountOfHits == 7) //checks if player 1 has won
                                {
                                    Console.WriteLine("Well done you have hit all 7 ships!");
                                    canContinue = false;
                                }
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("You have entered the wrong coordiate"); //an incorrect hit has been made
                        hitPlayer1[hitPlacementy, hitxcord] = "x";
                    }
                    validAnswer3 = false;

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Player 2: Please enter the x coordinate for where you want to hit?");
                    string hitPlacement2x = Console.ReadLine();
                    if (hitPlacement2x == "a") //checks the character the player gives
                    {
                        hitPlacement2x = "0"; //converts the character to an integer that the program can understand
                    }

                    else if (hitPlacement2x == "b")
                    {
                        hitPlacement2x = "1";
                    }

                    else if (hitPlacement2x == "c")
                    {
                        hitPlacement2x = "2";
                    }

                    else if (hitPlacement2x == "d")
                    {
                        hitPlacement2x = "3";
                    }

                    else if (hitPlacement2x == "e")
                    {
                        hitPlacement2x = "4";
                    }

                    else if (hitPlacement2x == "f")
                    {
                        hitPlacement2x = "5";
                    }

                    else if (hitPlacement2x == "g")
                    {
                        hitPlacement2x = "6";
                    }

                    else if (hitPlacement2x == "h")
                    {
                        hitPlacement2x = "7";
                    }

                    else if (hitPlacement2x == "i")
                    {
                        hitPlacement2x = "8";
                    }

                    else if (hitPlacement2x == "j")
                    {
                        hitPlacement2x = "9";
                    }

                    else
                    {
                        //creates a condition if player 1 has entered an invalid character, loops round the validAnswer condition loop
                        Console.WriteLine("Please enter a letter from a-jk");
                        validAnswer3 = true;
                    }
                    //converts the character that was just converted into an integer so the program can find its cell in the array
                    int hitxcord2 = Convert.ToInt32(hitPlacement2x);

                    Console.WriteLine("Player 2: Please enter the y coordinate for where you want to hit?");
                    int hitPlacement2y = Convert.ToInt32(Console.ReadLine());
                    if (hitPlacement2y > 11) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        hitPlacement2y = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (hitPlacement2y < 0) //creates a condition to check if the user's input is correct
                    {
                        Console.WriteLine("Please enter a valid number");
                        hitPlacement2y = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        //updates the 2D array of player 1's hits
                        hitPlacement2y = hitPlacement2y - 1;
                    }

                    if (player2[hitPlacement2y, hitxcord2] == "x") //checks if the user's "hit" is correct
                    {
                        player2[hitPlacement2y, hitxcord2] = "o"; //updates the array from x to c
                        Console.WriteLine("Entered correct hit");
                        var hitships2 = hitPlayer2.Length; //checks array length to start a count control loop
                        Console.WriteLine(hitships2);
                        //creates a count control loop for the length of the array
                        for (int winnerCheck = 0; winnerCheck < hitships2; winnerCheck++)
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                /*
                                if (winnerCheck%10 = 0) //reached a multiple of 10
                                {
                                    winnerCheck = winnerCheck - 
                                }
                                

                                if (10 < winnerCheck <= 19) {
                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (20 < winnerCheck <= 29)
                                {
                                    winnerCheck = winnerCheck - 20;
                                }
                                else if (30 < winnerCheck <= 39)
                                {
                                    winnerCheck = winnerCheck - 30;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {
                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                else if (10 < winnerCheck <= 19)
                                {

                                    winnerCheck = winnerCheck - 10;
                                }
                                */
                               
                                if (player2[winnerCheck, i] == "o") //finds the arrays that have a hit "o"
                                {
                                    //if it has a correct hit then it adds to the amountOfHits
                                    int amountOfHits2 = 0;
                                    amountOfHits2 = amountOfHits2 + 1;
                                    Console.WriteLine(amountOfHits2);
                                    if (amountOfHits2 == 7) //checks if player 2 has won
                                    {
                                        Console.WriteLine("Well done you have hit all 7 ships!");
                                        canContinue = false;
                                    }
                                }
                            }
                        }
                    }

                    else
                    {
                        hitPlayer1[hitPlacementy, hitxcord] = "x";
                        Console.WriteLine("You have entered the wrong coordiate");
                    }

                }
            }
            

            Console.WriteLine("Would you like to play again?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                canContinue = true;
            }

            else if (answer == "y")
            {
                canContinue = true;
            }

            else
            {
                Console.WriteLine("Thank you for playing!");
                canContinue = false;
            }
            
        }
    }
}
