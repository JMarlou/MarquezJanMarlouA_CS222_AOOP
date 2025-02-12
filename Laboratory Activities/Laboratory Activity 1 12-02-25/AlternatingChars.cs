using System;

public class AlternatingChar
{
    public static void Main(string[] args)
    {
        Console.Write("Enter First Character: ");
        char a = char.Parse(Console.ReadLine());
        Console.Write("Enter Second Character: ");
        char b = char.Parse(Console.ReadLine());
        Console.Write("Enter Size: ");
        int size = int.Parse(Console.ReadLine());
        
        for (int i = 1;i <= size; i++){
           for (int j = 1; j < i; j++){
               Console.Write('*');
           }
           if (i%2 == 0){
               Console.Write(b);
           }
           else{
               Console.Write(a);
           }
         
        Console.WriteLine();
        }
    }
}

