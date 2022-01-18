using System;

namespace ConsoleApp1
{
    static void Main(String[] args)
    {
        Console.WriteLine("Please enter a number:");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Value of a is even");
        }
        else
        {
            Console.WriteLine("Value of a is odd");
        }
    }
}
