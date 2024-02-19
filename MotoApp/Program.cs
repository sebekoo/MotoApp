using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;

var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
AddEmployees(employeeRepository);
//AddManagers(employeeRepository);
WriteAllToConsole(employeeRepository);

static void AddEmployees(IRepository<Employee> employeeRepository)
{
    var employees = new List<Employee>()
    {
        new Employee { FirstName = "Adam" },
        new Employee { FirstName = "Piotr" },
        new Employee { FirstName = "Zuzia" }
    };

    AddBatch(employeeRepository, employees);

    //employeeRepository.Add(new Employee { FirstName = "Adam" });
    //employeeRepository.Add(new Employee { FirstName = "Piotr" });
    //employeeRepository.Add(new Employee { FirstName = "Zuzia" });
    //employeeRepository.Save();
}

static void AddBatch(IRepository<Employee> employeeRepository, List<Employee> employees)
{
    foreach (var employee in employees)
    {
        employeeRepository.Add(employee);
    }

    employeeRepository.Save();
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