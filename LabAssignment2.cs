using System;
using System.Collections.Generic;

namespace LabAssignment2
{
    public class UserProfile
    {
        private string username;
        private string password;
        private string email;

        public string Username
        {
            get => username;
            set => username = value;
        }

        public string Password
        {
            get => password;
            set
            {
                if (value.Length >= 6)
                    password = value;
                else
                    Console.WriteLine("Password must be at least 6 characters.");
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (value.Contains("@"))
                    email = value;
                else
                    Console.WriteLine("Invalid email address.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Username: {username}, Email: {email}");
        }
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class Truck : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Truck: {Make} {Model}, Year {Year}");
        }
    }

    public class Bus : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Bus: {Make} {Model}, Year {Year}");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b, double c) => a + b + c;
    }

    public abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }

    public class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double CalculateSalary() => MonthlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public override double CalculateSalary() => HoursWorked * HourlyRate;
    }

    public class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Marks { get; set; }

        public Student() { }
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
        public Student(string name, int rollNo, int marks)
        {
            Name = name;
            RollNo = rollNo;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Roll: {RollNo}, Marks: {Marks}");
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        private double price;
        public double Price
        {
            get => price;
            set
            {
                if (value >= 0) price = value;
                else Console.WriteLine("Price cannot be negative!");
            }
        }
        public int Quantity { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Qty: {Quantity}");
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    public class Member
    {
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; } = new List<Book>();
    }

    public class Library
    {
        public List<Book> Books { get; } = new List<Book>();
        public List<Member> Members { get; } = new List<Member>();

        public void RegisterMember(Member m) => Members.Add(m);

        public void LendBook(Book b, Member m)
        {
            if (b.IsAvailable)
            {
                b.IsAvailable = false;
                m.BorrowedBooks.Add(b);
                Console.WriteLine($"{m.Name} borrowed {b.Title}");
            }
            else
            {
                Console.WriteLine($"{b.Title} is not available");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose Experiment (1-7): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    UserProfile u1 = new UserProfile();
                    u1.Username = "yash";
                    u1.Password = "12345";
                    u1.Password = "123456";
                    u1.Email = "yash@abc.com";
                    u1.Display();

                    UserProfile u2 = new UserProfile { Username = "rahul", Password = "abcdef", Email = "rahul@xyz.com" };
                    u2.Display();
                    break;

                case 2:
                    Truck t = new Truck { Make = "Tata", Model = "X1", Year = 2020 };
                    t.DisplayDetails();
                    Bus b = new Bus { Make = "Volvo", Model = "B7R", Year = 2021 };
                    b.DisplayDetails();
                    break;

                case 3:
                    Calculator calc = new Calculator();
                    Console.WriteLine(calc.Add(2, 3));
                    Console.WriteLine(calc.Add(2.5f, 3.5f));
                    Console.WriteLine(calc.Add(1.1, 2.2, 3.3));
                    break;

                case 4:
                    FullTimeEmployee fte = new FullTimeEmployee { Name = "Amit", MonthlySalary = 50000 };
                    PartTimeEmployee pte = new PartTimeEmployee { Name = "Ravi", HoursWorked = 40, HourlyRate = 200 };
                    Console.WriteLine($"{fte.Name} Salary: {fte.CalculateSalary()}");
                    Console.WriteLine($"{pte.Name} Salary: {pte.CalculateSalary()}");
                    break;

                case 5:
                    Student s1 = new Student();
                    Student s2 = new Student("Raj", 101);
                    Student s3 = new Student("Simran", 102, 90);
                    s1.Display();
                    s2.Display();
                    s3.Display();
                    break;

                case 6:
                    Product p1 = new Product { ProductID = 1, ProductName = "Laptop", Price = 50000, Quantity = 5 };
                    p1.PrintDetails();
                    Product p2 = new Product { ProductID = 2, ProductName = "Mouse", Price = -200, Quantity = 10 };
                    p2.PrintDetails();
                    break;

                case 7:
                    Library lib = new Library();
                    Book book1 = new Book { Title = "C# Basics" };
                    Book book2 = new Book { Title = "OOP Concepts" };
                    lib.Books.Add(book1);
                    lib.Books.Add(book2);

                    Member m1 = new Member { Name = "Karan" };
                    lib.RegisterMember(m1);

                    lib.LendBook(book1, m1);
                    lib.LendBook(book1, m1);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
