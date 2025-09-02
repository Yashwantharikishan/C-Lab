using System;

// Q1: BankAccount
public class BankAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount)
    {
        if (amount <= Balance)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient Balance!");
    }
}

// Q2: Student
public class Student
{
    private int age;
    public int Age
    {
        get => age;
        set => age = (value >= 5 && value <= 25) ? value : 18;
    }
}

// Q3: Employee
public class Employee
{
    private double basicSalary;
    public double BasicSalary { set => basicSalary = value; }
    public double TotalSalary => basicSalary + (basicSalary * 0.2);
}

// Q4: Product
public class Product
{
    public double Price { get; set; }
    public double Discount { get; set; }
    public double FinalPrice() => Price - (Price * Discount / 100);
}

// Q5: Car
public class Car
{
    private int speed;
    public int Speed
    {
        get => speed;
        set => speed = (value > 180) ? 180 : value;
    }
}

// Q6: Delegate Operation
public delegate int Operation(int a, int b);

// Q7: Delegate FormatText
public delegate string FormatText(string input);

// Q8: Delegate BillingOperation
public delegate double BillingOperation(double amount);

// Q9: Delegate ConvertTemperature
public delegate void ConvertTemperature(double celsius);

// Q10: Delegate Notifier
public delegate void Notifier(string message);
