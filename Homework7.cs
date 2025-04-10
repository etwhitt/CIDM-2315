﻿namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2

        Customer customer1 = new Customer(110, "Alice", 28);
        Customer customer2 = new Customer(111, "Bob", 30);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.ChangeID(220);
        customer2.ChangeID(221);

        customer1.PrintCusInfo();
        customer2.PrintCusInfo();

        customer1.CompareAge(customer2);
    }
}

class Customer
{
    //Code for Customer class
    
    private int cus_id;
    public string cus_name {get; set;}
    public int cus_age {get; set;}

    public Customer(int cus_id, string cus_name, int cus_age)
    {
        this.cus_id = cus_id;
        this.cus_name = cus_name;
        this.cus_age = cus_age;
    }

    public void ChangeID(int new_id)
    {
        this.cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer ID: {cus_id}, Name: {cus_name}, Age: {cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine("Both customers are of the same age.");
        }
    }
}
