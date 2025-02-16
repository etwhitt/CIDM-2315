using System.Net.NetworkInformation;
using System.Reflection.Metadata;

namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 Method
        Console.WriteLine("Input two integers to determine which is larger.");

        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"a = {a}; b = {b}");
        Console.WriteLine($"The largest number is: {LargestNumber(a, b)}.");


        //Call Q2 Method
        Console.WriteLine("Please input an integer.");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter, in lowercase letters, \"left\" or \"right.\"");
        string? shape = Console.ReadLine();

        Console.WriteLine($"N is: {num}; shape is {shape}.");

        Triangle(num, shape!);
    }

    //Q1 Method
    static int LargestNumber(int num1, int num2) 
    {
        if (num1 > num2) {
            return num1;
        }
        else {
            return num2;
        }
    }


    //Q2 Method
    static void Triangle(int num, string shape)
    {
        if (shape == "left") {
            for (int row = 1; row <= num; row++) {
                for (int col = 1; col <= row; col++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else if (shape == "right") {
            for (int row = 1; row <= num; row++) {
                for (int col = 1; col <= num - row; col++) {
                    Console.Write(" ");
                }
                for (int col = 1; col <= row; col++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        else {
            Console.WriteLine("Invalid input. Please use lowercase letters to input either \"left\" or \"right\".");
        }
    }
}
