using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 8;
            int temporaryNumber;
            Console.Write("\nInput the First Number : "); 
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temporaryNumber = number1;
            number1 = number2;
            number2 = temporaryNumber;
            Console.Write("\nThe numbers are swapped : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.ReadLine();

        }
      
    }
}
