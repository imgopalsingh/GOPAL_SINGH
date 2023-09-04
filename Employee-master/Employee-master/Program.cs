using System;


class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int age, double salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
    public void Employee_detail()
    {
        Console.WriteLine("Employee Name : " + Name);
        Console.WriteLine("Employee Age : " + Age);
        Console.WriteLine("Employee Salary :" + Salary);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Rajesh Kumar", 22, 100000.00);
            Console.WriteLine("Employee_details : ");
            emp.Employee_detail();
        }
    }
}
