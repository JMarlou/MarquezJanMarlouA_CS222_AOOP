using System;

class TheFinalTotal
{
    static void Main()
    {
        int total = 10;

        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            if (number % 2 == 0)
            {
                int square = number * number;
                total += square;
                Console.WriteLine("The number is even.");
            }
            else
            {
                int cube = number * number * number;
                total += cube;
                Console.WriteLine("The number is odd.");
            }

            Console.WriteLine(total);
        }
        else if (number < 0)
        {
            Console.Write("Enter an exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            double result = Math.Pow(number, exponent);
            total += (int)result;

            Console.WriteLine("Updated total = " + total);
        }
        else 
        {
            Console.WriteLine("Nothing happened.");
        }
    }
}
