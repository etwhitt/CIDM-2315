namespace Homework2;

class Homework2
{
    static void Main(string[] args)
    {
        //Code for Q1
        Console.WriteLine("Please input a letter grade:");
        string? grade = Console.ReadLine();

        switch(grade) 
        {
            case "A":
            case "a":
                Console.WriteLine("GPA point: 4");
                break;
            
            case "B":
            case "b":
                Console.WriteLine("GPA point: 3");
                break;

            case "C":
            case "c":
                Console.WriteLine("GPA point: 2");
                break;

            case "D":
            case "d":
                Console.WriteLine("GPA point: 1");
                break;

            case "F":
            case "f":
                Console.WriteLine("GPA point: 0");
                break;

            default:
                Console.WriteLine("Wrong Letter Grade!");
                break;
        }

        //Code for Q2
        Console.WriteLine("Please input the first num:");
        int num1 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the second num:");
        int num2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input the third num:");
        int num3 = Convert.ToInt16(Console.ReadLine());

        if (num1 < num2 && num1 < num3) {
            Console.WriteLine("The smallest value is: " + num1);
        }
            else if (num2 < num1 && num2 < num3) {
                Console.WriteLine("The smallest value is: " + num2);
            }
            else if (num3 < num1 && num3 < num2) {
                Console.WriteLine("The smallest value is: " + num3);
            }
            else {
                Console.WriteLine("Two or more values are the same");
            }


        //Code for Q3
        Console.WriteLine("Please input a year:");
        int year = Convert.ToInt16(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
            Console.WriteLine(year + " is a leap year.");
        }
        else {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}
