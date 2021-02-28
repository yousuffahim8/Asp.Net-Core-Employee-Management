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
                new Employee(){id=1, name="Yousuf", department= Dept.IT, email="Yousuf@gmail.com"},
                new Employee(){id=2, name="Fahim", department= Dept.HR, email="Fahim@gmail.com"},
                new Employee(){id=3, name="Hossain", department= Dept.None, email="Hossain@gmail.com"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.id= _employeeList.Max(e => e.id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.id==id);
        }
    }
}
