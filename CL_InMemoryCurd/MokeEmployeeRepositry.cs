using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_InMemoryCurd
{
     class MokeEmployeeRepositry : IEmployeeRepository
    {
        public static List<Employee> employeesList;
        public MokeEmployeeRepositry()
        {
            employeesList = new List<Employee>()
            {
                new Employee(){ id = 1, name = "arun", salary = 50000, address = "Jarua"},
                new Employee(){id = 2, name = "ajay", salary = 40000, address = "Agra"},
                new Employee(){id = 3, name = "reetesh", salary = 60000, address = "Jarua katra"},
                new Employee(){id = 4, name = "saurabh", salary = 35000, address = "Mathura"},
            };
        }
        
        public Employee Add(Employee employee)
        {
            employee.id = employeesList.Max(x => x.id)+1;
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee e = employeesList.FirstOrDefault(x => x.id == id);
            if (e != null)
            {
                employeesList.Remove(e);
            }
            return e;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return employeesList;
        }

        public Employee GetEmployee(int id)
        {
            Employee e1 = employeesList.FirstOrDefault(a =>  a.id == id);
            return e1;
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee e = employeesList.FirstOrDefault(a => a.id==employeeChanges.id);
            if (e != null)
            {
                e.id = employeeChanges.id;
                e.name = employeeChanges.name;
                e.address = employeeChanges.address;
                e.salary = employeeChanges.salary;
            }
            return e;
        }
    }
}
