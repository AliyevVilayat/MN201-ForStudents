namespace Core.Enitites;

public class SalariedEmployee : Employee
{
    public double MonthlySalary { get; set; }
    public SalariedEmployee(string name, string surname, int age,double monthlySalary) : base(name, surname, age)
    {
        MonthlySalary = monthlySalary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"Salaried Employee's Name:{Name} Surname:{Surname} MonthlySalary{MonthlySalary}");
    }
}
