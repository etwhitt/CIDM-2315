namespace Homework5;

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
        Console.WriteLine("Input four integers to determine which is larger.");

        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"c = {c}; d = {d}; e = {e}; f = {f}");

        int max2 = LargestNumberAgain(c, d);
        int max3 = LargestNumberAgain(max2, e);
        int max4 = LargestNumberAgain(max3, f);

        Console.WriteLine($"The largest number is: {max4}");

        //Call Q3 Method
        CreateAccount();
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

    //Q2 Method (Same as Q1 Method)
    static int LargestNumberAgain(int num1, int num2) 
    {
        if (num1 > num2) {
            return num1;
        }
        else {
            return num2;
        }
    }

    //Q3 Method
    static bool CheckAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        return age >= 18;
    }

    static void CreateAccount()
    {
        Console.WriteLine("Enter your username:");
        string username = Console.ReadLine()!;

        Console.WriteLine("Enter your password:");
        string password = Console.ReadLine()!;

        Console.WriteLine("Enter your password again:");
        string confirmPassword = Console.ReadLine()!;

        Console.WriteLine("Enter your birth year:");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        if (CheckAge(birthYear))
        { 
            if (password == confirmPassword) {
                Console.WriteLine("Account was created successfully.");
            }
            else {
                Console.WriteLine("Wrong password.");
            }
        }
        else {
            Console.WriteLine("Could not create an account.");
        }
    }
}
