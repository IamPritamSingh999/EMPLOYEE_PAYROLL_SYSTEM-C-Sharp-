using System;

// Interface
interface IPayroll
{
    void CalculateSalary();
}

// Parent Class
class Employee
{
    protected int id;
    protected string name;

    public Employee(int id, string name)
    {
        this.id = id;
        this.name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee ID   : " + id);
        Console.WriteLine("Employee Name : " + name);
    }
}

// Child Class
class FullTimeEmployee : Employee, IPayroll
{
    private double salary;
    private double bonus;
    private int hoursWorked;
    private double pf;

    public FullTimeEmployee(int id, string name, double salary,
                            double bonus, int hoursWorked, double pf)
        : base(id, name)
    {
        this.salary = salary;
        this.bonus = bonus;
        this.hoursWorked = hoursWorked;
        this.pf = pf;
    }

    public void CalculateSalary()
    {
        double netSalary = salary + bonus - pf;

        Console.WriteLine("Basic Salary  : " + salary);
        Console.WriteLine("Bonus         : " + bonus);
        Console.WriteLine("Hours Worked  : " + hoursWorked);
        Console.WriteLine("PF Deduction  : " + pf);
        Console.WriteLine("Net Salary    : " + netSalary);
    }

    public override void Display()
    {
        Console.WriteLine("\n--- Employee Payroll System ---");
        base.Display();
        Console.WriteLine("Employee Type : Full Time");
        CalculateSalary();
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new FullTimeEmployee(
            45,
            "Chandra Babu",
            45000,
            5000,
            180,
            4500
        );

        emp.Display();

        Console.ReadLine();
    }
}