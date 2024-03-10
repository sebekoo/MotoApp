using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;
using MotoApp.Repositories.Extensions;

var itemAdded = new ItemAdded(EmployeeAdded);
var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext(), itemAdded);
AddEmployees(employeeRepository);
//AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void EmployeeAdded(object item)
{
    var employee = (Employee)item;
    Console.WriteLine($"{employee.FirstName} added");
}

static void AddEmployees(IRepository<Employee> repository)
{
    var employees = new[]
    {
        new Employee { FirstName = "Adam" },
        new Employee { FirstName = "Piotr" },
        new Employee { FirstName = "Zuzanna" }
    };

    repository.AddBatch(employees);
    "string".AddBatch(employees);
    //AddBatch(employeeRepository, employees);

    //employeeRepository.Add(new Employee { FirstName = "Adam" });
    //employeeRepository.Add(new Employee { FirstName = "Piotr" });
    //employeeRepository.Add(new Employee { FirstName = "Zuzia" });
    //employeeRepository.Save();
}

//static void AddManagers(IWriteRepository<Manager> managerRepository)
//{
//    managerRepository.Add(new Manager { FirstName = "Przemek" });
//    managerRepository.Add(new Manager { FirstName = "Tomek" });
//    managerRepository.Save();
//}

static void WriteAllToConsole(IReadRepository<IEntity> repository)
{
    var items = repository.GetAll();
    foreach (var item in items)
    {
        Console.WriteLine(item);
    }
}