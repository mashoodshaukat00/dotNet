// See https://aka.ms/new-console-template for more information
bool exit = false;
string firstName = "";
string lastName = "";

List<Employee> employees = [];

do
{
    Console.Clear();
    DisplayEmployees();

    Console.WriteLine("Please press the 'A' key to add and employee, or press any other key to exit the app");
    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.A)
    {
        Console.WriteLine();
        Console.Write("Please enter the employee's first name: ");
        firstName = Console.ReadLine() ?? "";
        Console.Write("Please enter the employee's last name: ");
        lastName = Console.ReadLine() ?? "";
        
        var emp = new Employee ( firstName, lastName );

        if (!employees.Contains(emp))
        {
            employees.Add(emp);
            
        }

    }
    else
    {
        exit = true;
    }
}
while (!exit);


void DisplayEmployees()
{
    foreach(Employee emp in employees)
    {
        Console.WriteLine($"{emp.FirstName} {emp.LastName}");
    }
}


//class Employee
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//}

//we will use 'record' instead of a class.

record Employee(string FirstName, string LastName);