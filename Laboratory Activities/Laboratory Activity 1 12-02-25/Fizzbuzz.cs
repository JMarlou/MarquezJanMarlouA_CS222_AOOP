using System;

public class Fizzbuzz
{
    public static void Main(string[] args)
    {
        Console.Write("Enter upperbound number: ");
        int UpperBound = int.Parse(Console.ReadLine());
        for (int i = 1; i <= UpperBound; i++){
            if (i%3 == 0){
                Console.WriteLine("Fizz");
            }
            else if (i%5 == 0){
                Console.WriteLine("Buzz");
            }
            else 
        Console.WriteLine (i);
        }
    }
}

