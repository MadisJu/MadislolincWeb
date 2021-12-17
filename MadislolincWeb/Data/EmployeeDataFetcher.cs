using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;


namespace MadislolincWeb.Data
{
    public class EmployeeDataFetcher
    {
        public Task<Employee[]> GetEmployeesAsync()
        {

            String datatext = File.ReadAllText("wwwroot/data/EmployeeData.json");
            Employee[] employees = JsonSerializer.Deserialize<Employee[]>(datatext);

            return Task.FromResult(Enumerable.Range(0, employees.Length).Select(Index => new Employee
            {
                Firstname = employees[Index].Firstname,
                Lastname = employees[Index].Lastname,
                Email = employees[Index].Email,
                Phone = employees[Index].Phone,
                ImageName = employees[Index].ImageName
            }
            ).ToArray());
        }
    }
}
