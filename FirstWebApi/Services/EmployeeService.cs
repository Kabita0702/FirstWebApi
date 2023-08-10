using FirstWebApi.EmployeeData;
using FirstWebApi.Json;
using FirstWebApi.Models;

namespace FirstWebApi.Services
{
    public class EmployeeService
    {
        public Employee GetEmployee(int id)
        {
            var employeeList = StoreData.GetEmployeeData();
            var employee = employeeList.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                throw new Exception("Data not found");
            }
            return employee;
        }
    }
}
