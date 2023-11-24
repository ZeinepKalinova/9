using System;

class Employee
{
    protected string name;
    protected int age;
    protected decimal salary;

    public Employee(string name, int age, decimal salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public virtual void GetInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
    }

    public virtual decimal CalculateAnnualSalary()
    {
        return salary * 12;
    }
}

class Manager : Employee
{
    private decimal bonus;

    public Manager(string name, int age, decimal salary, decimal bonus)
        : base(name, age, salary)
    {
        this.bonus = bonus;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Bonus: {bonus}");
    }

    public override decimal CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + bonus;
    }
}

class Developer : Employee
{
    private int linesOfCodePerDay;

    public Developer(string name, int age, decimal salary, int linesOfCodePerDay)
        : base(name, age, salary)
    {
        this.linesOfCodePerDay = linesOfCodePerDay;
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Lines of Code per Day: {linesOfCodePerDay}");
    }

    public override decimal CalculateAnnualSalary()
    {
        return base.CalculateAnnualSalary() + (linesOfCodePerDay * 250); 
    }
}

class Program
{
    static void Main()
    {
        Manager manager = new Manager("John Manager", 35, 60000, 5000);
        Developer developer = new Developer("Jane Developer", 28, 70000, 100);

        Console.WriteLine("Manager Information:");
        manager.GetInfo();
        Console.WriteLine($"Annual Salary: {manager.CalculateAnnualSalary()}");

        Console.WriteLine("\nDeveloper Information:");
        developer.GetInfo();
        Console.WriteLine($"Annual Salary: {developer.CalculateAnnualSalary()}");
    }
}
