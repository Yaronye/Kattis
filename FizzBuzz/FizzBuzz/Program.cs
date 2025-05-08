using System;
//if divisable by x, fizz. if divisable by y, buzz.

public class Program
{
    public static void Main()
    {
        string input = Console.ReadLine();
        string[] STRnumber = input.Split(' ');

        int x = Convert.ToInt32(STRnumber[0]);
        int y = Convert.ToInt32(STRnumber[1]);
        int n = Convert.ToInt32(STRnumber[2]);

        for (int i = 1; i <= n; i++)
        {
            if (i % x == 0 & i % y == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % x == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % y == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}


