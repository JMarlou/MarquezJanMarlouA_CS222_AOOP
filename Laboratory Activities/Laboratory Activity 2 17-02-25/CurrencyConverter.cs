using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double originalAmount = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter exchange rate from USD to EURO: ");
        double exchangeRate = Convert.ToDouble(Console.ReadLine());

        double convertedAmount = originalAmount * exchangeRate;

        // Output result
        Console.WriteLine("Amount in EURO = " + convertedAmount);
    }
}
