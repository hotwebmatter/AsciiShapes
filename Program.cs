/**
 * ######################################################
 * ##    Programming Assignment #9                     ##
 * ##    Developer: Matthew Obert                      ##
 * ##    Date Submitted: September 06 2019             ##
 * ##    Purpose: Generate algorithmic shapes.         ##
 * ######################################################
 */

using System;
using static System.Console;

namespace AsciiShapes
{
    class Program
    {
        static void WriteMenu(string output)
        {
            Clear();
            WriteLine("Choose an option:\n1 = ASCII Art Shapes\n2 = Algorithmic Shapes\n");
            WriteLine("To exit, press 0 (zero) key.\n\n");
            WriteLine(output);
        }

        static void RepeatChar(string character, int reps)
        {
            for (int i = 0; i < reps; i++)
            {
                Write(character);
            }
        }

        static void GenerateShapes(int width)
        {
            WriteLine("The desired width is {0}.", width);
            WriteLine();

            // generate algorithmic Shapes
            int j = 1;
            for (int i = 1; i < width * 2; i = i + 2)
            {
                // square
                RepeatChar("*", width);
                RepeatChar(" ", 5);

                // triangle
                RepeatChar(" ", ((width * 2) - i) / 2);
                RepeatChar("*", i);
                RepeatChar(" ", ((width * 2) - i) / 2);

                // diamond
                RepeatChar(" ", ((width * 2) - j) / 2);
                RepeatChar("*", j);
                WriteLine();

                if (i < width)
                {
                    j = j + 2;
                }
                else
                {
                    j = j - 2;
                }
            }
        }
        static void Main(string[] args)
        {
            string input;
            string message = "";
            int choice = 0;
            while (0 == 0)
            {
                WriteMenu(message);
                input = ReadLine();
                while (!int.TryParse(input, out choice))
                {
                    message = "Invalid input.\nPlease choose a number: 0, 1, or 2.";
                    WriteMenu(message);
                    input = ReadLine();
                }
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    case 1:
                        WriteLine("Generating ASCII Art Shapes ...");
                        WriteLine();
                        WriteLine("*********             *              *");
                        WriteLine("*********            ***            ***");
                        WriteLine("*********           *****          *****");
                        WriteLine("*********          *******        *******");
                        WriteLine("*********         *********      *********");
                        WriteLine("*********        ***********      *******");
                        WriteLine("*********       *************      *****");
                        WriteLine("*********      ***************      ***");
                        WriteLine("*********     *****************      *");
                        WriteLine();
                        WriteLine("Press any key to return to menu.");
                        ReadKey();
                        break;
                    case 2:
                        message = "Generating Algorithmic Shapes ...\nEnter desired width of shapes:";
                        WriteMenu(message);
                        input = ReadLine();
                        while (!int.TryParse(input, out choice))
                        {
                            message = "Generating Algorithmic Shapes ...\nEnter desired width of shapes:\n";
                            message += "\nInvalid input.\nPlease choose a number.";
                            WriteMenu(message);
                            input = ReadLine();
                        }
                        GenerateShapes(choice);
                        message = "";
                        WriteLine("Press any key to return to menu.");
                        ReadKey();
                        break;
                    default:
                        message = "Please choose 0, 1, or 2 next time.";
                        WriteMenu(message);
                        break;
                }
            }
        }
    }
}
