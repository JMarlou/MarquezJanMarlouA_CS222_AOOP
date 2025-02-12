using System;

public class SquarePattern
{
    public static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        
        
        for (int i = 1; i <= n; i++){
           for (int j = 1; j <= n; j++){
               if (i == y){
                   break;
               }
               Console.Write('*');
           }
           Console.WriteLine();
        };
    }
}

