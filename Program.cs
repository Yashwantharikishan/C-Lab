using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization;

class Program
{
    static void Main()
    {
        // Q1
        Console.WriteLine("Q1: BankAccount");
        BankAccount account = new BankAccount();
        account.Deposit(1000);
        Console.WriteLine("Balance after deposit: " + account.Balance);
        account.Withdraw(500);
        Console.WriteLine("Balance after withdrawal: " + account.Balance);
        Console.WriteLine("--------------------");

        // Q2
        Console.WriteLine("Q2: Student");
        Student s1 = new Student { Age = 4 };
        Student s2 = new Student { Age = 20 };
        Student s3 = new Student { Age = 30 };
        Console.WriteLine("Age (4): " + s1.Age);
        Console.WriteLine("Age (20): " + s2.Age);
        Console.WriteLine("Age (30): " + s3.Age);
        Console.WriteLine("--------------------");

        // Q3
        Console.WriteLine("Q3: Employee");
        Employee emp = new Employee();
        emp.BasicSalary = 30000;
        Console.WriteLine("Total Salary = " + emp.TotalSalary);
        Console.WriteLine("--------------------");

        // Q4
        Console.WriteLine("Q4: Product");
        Product p = new Product { Price = 2000, Discount = 10 };
        Console.WriteLine("Final Price = " + p.FinalPrice());
        Console.WriteLine("--------------------");

        // Q5
        Console.WriteLine("Q5: Car");
        Car c = new Car();
        c.Speed = 150;
        Console.WriteLine("Speed = " + c.Speed);
        c.Speed = 200;
        Console.WriteLine("Final Speed = " + c.Speed);
        Console.WriteLine("--------------------");

        // Q6
        Console.WriteLine("Q6: Delegate Operation");
        Operation op = (x, y) => x + y;
        Console.WriteLine("Addition: " + op(10, 5));
        op = (x, y) => x - y;
        Console.WriteLine("Subtraction: " + op(10, 5));
        Console.WriteLine("--------------------");

        // Q7
        Console.WriteLine("Q7: Delegate FormatText");
        FormatText ft = str => str.ToUpper();
        Console.WriteLine("Uppercase: " + ft("Hello World"));
        ft = str => str.ToLower();
        Console.WriteLine("Lowercase: " + ft("Hello World"));
        Console.WriteLine("--------------------");

        // Q8
        Console.WriteLine("Q8: Delegate BillingOperation");
        double price = 5000;
        BillingOperation bill = ShowTotal;
        bill += ApplyDiscount;
        bill += AddTax;
        bill += FinalBill;
        bill(price);
        Console.WriteLine("--------------------");

        // Q9
        Console.WriteLine("Q9: ConvertTemperature");
        ConvertTemperature ct = ToFahrenheit;
        ct += ToKelvin;
        ct(25);
        Console.WriteLine("--------------------");

        // Q10
        Console.WriteLine("Q10: Notifier");
        Notifier notify = SendEmail;
        notify += SendSMS;
        notify("Assignment Submitted Successfully");
    }

    // Q8 methods
    static double ShowTotal(double amt) { Console.WriteLine("Original Price: " + amt); return amt; }
    static double ApplyDiscount(double amt) { double d = amt - (amt * 0.1); Console.WriteLine("After Discount: " + d); return d; }
    static double AddTax(double amt) { double t = amt + (amt * 0.18); Console.WriteLine("After Tax: " + t); return t; }
    static double FinalBill(double amt) { Console.WriteLine("Final Bill: " + amt); return amt; }

    // Q9 methods
    static void ToFahrenheit(double c) => Console.WriteLine($"Celsius to Fahrenheit: {(c * 9 / 5) + 32}");
    static void ToKelvin(double c) => Console.WriteLine($"Celsius to Kelvin: {c + 273.15}");

    // Q10 methods
    static void SendEmail(string msg) => Console.WriteLine("Email Sent: " + msg);
    static void SendSMS(string msg) => Console.WriteLine("SMS Sent: " + msg);
}
