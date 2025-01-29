// Zadanie domowe dzień 6

using ChellengeApp;

Employee employee1 = new Employee("Aureliusz", "Mazur", 44);
Employee employee2 = new Employee("Agnieszka", "Ziółkowska", 35);
Employee employee3 = new Employee("Ambroży", "Tomaszewski", 37);

employee1.AddScore(3);
employee1.AddScore(5);
employee1.AddScore(6);
employee1.AddScore(2);
employee1.AddScore(7);

employee2.AddScore(8);
employee2.AddScore(10);
employee2.AddScore(2);
employee2.AddScore(4);
employee2.AddScore(2);

employee3.AddScore(10);
employee3.AddScore(10);
employee3.AddScore(8);
employee3.AddScore(8);
employee3.AddScore(3);


List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}


Console.WriteLine("Pracownik z największą sumą ocen");
Console.WriteLine($"{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat {employeeWithMaxResult.Age} uzyskał wynik wynik: {employeeWithMaxResult.Result}");
