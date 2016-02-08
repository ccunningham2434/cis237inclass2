using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Factorial
    {

        // >Constructors
        //
        public Factorial()
        {
            // >Prompt the user.
            Console.WriteLine("Input a number to calculate the factorial of: ");

            try
            {
                // >The number to perform factorial on.
                int factorialInt = Convert.ToInt32(Console.ReadLine());

                // >Get a number from the user.
                Console.WriteLine(Environment.NewLine + "Problem: " + factorialInt + "!");

                // >Solve the problem.
                int anserInt = Calculate(factorialInt);

                Console.WriteLine(Environment.NewLine + "The answer is: " + anserInt + Environment.NewLine);
            }
            catch
            {
                Console.WriteLine("You did not enter a valid integer");
            }
        }

        // >This is a recursive method.
        // >Continue calling until 1 is reached, then return and calculate.
        private int Calculate(int number)
        {
            // >If the number is 1, we have reached the Base Case.
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Calculate(number - 1);
            }
        }

    }

}
