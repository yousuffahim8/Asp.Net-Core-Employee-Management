using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Management.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){id=1, name="Yousuf", Department= "IT", Email="Yousuf@gamil.com"},
                new Employee(){id=2, name="Fahim", Department= "HR", Email="Fahim@gamil.com"},
                new Employee(){id=3, name="Hossain", Department= "IT", Email="Hossain@gamil.com"}
            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.id==id);
        }
    }
}
