//Grading ID: S0941
//CIS 199-02
//Lab 7
//Due: 4/4/21
// This Lab allows the user to enter a positive integer representing the number of stars per side desired.
// It then prints a solid square of asterisks that is the user's input tall and the user's input wide.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; //integer variable
            bool flag = false; //bool set to false to check if input is an integer greater than 0

            do
            {
                // display message for input
                Console.WriteLine("Enter number of Stars : ");

                //Tryparses user input to check if its an integer and greater than 0, if false, bool stays as false
                flag = int.TryParse(Console.ReadLine(), out x) && x > 0;

                // calling ShowSquareOfStars method and passing user input x
                ShowSquareOfStars(x);
            } while (!flag); // runs until flag bool is true
        }

        public static void ShowSquareOfStars(int numStars)
        {
            // loop till i is less than or equal to numStars
            for (int i = 1; i <= numStars; i++)
            {
                //loop till i is less than or equal to numStars
                for (int j = 1; j <= numStars; j++)
                    Console.Write("*"); // printing *
                Console.Write("\n"); // printing newline
            }
        }
    }
}
