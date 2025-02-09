using System.Globalization;

namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        //Code for Q1
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n <= 1) {
            Console.WriteLine(n + " is non-prime.");
        }
        else {
            bool prime = true;
            for (int i = 2; i < n; i++) {
                if (n % i == 0) {
                    prime = false;
                    break;
                }
            }
            if (prime) {
                Console.WriteLine(n + " is prime.");
            }
            else {
                Console.WriteLine(n + " is non-prime.");
            }
        }

        //Code for Q2
        Console.WriteLine("Assign an int value to N:");
        int n1 = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row < n1; row++) {
            for (int col = 0; col < n1; col++) {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        //Code for Q3
        Console.WriteLine("Assign an int value to N:");
        int n2 = Convert.ToInt32(Console.ReadLine());
        
        for (int row = 1; row <= n2; row++) {
            for (int col = 1; col <= row; col++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Code for Bonus
        Console.WriteLine("Assign an int value to N:");
        int n3 = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <= n3; row++) {
            for (int col = 1; col <= n3 - row; col++) {
                Console.Write(" ");
            }
            for (int col = 1; col <= row; col++) {
                Console.Write(row);
            }
            Console.WriteLine();
        }
    }
}