using System.Xml.Linq;

namespace CL_InMemoryCurd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MokeEmployeeRepositry mokeEmployeeRepositry = new MokeEmployeeRepositry();

            Employee emp = mokeEmployeeRepositry.Add(new Employee { name ="atul", salary = 23456, address = "Eata"});
            Console.WriteLine("Added employee is {0} {1} {2} {3}", emp.id,emp.name, emp.salary, emp.address);

            Employee emp1 = mokeEmployeeRepositry.Delete(2);
            Console.WriteLine("Deleted Employee is {0} {1} {2} {3}", emp1.id, emp1.name, emp1.salary, emp1.address);

            foreach(Employee emp2 in mokeEmployeeRepositry.GetAllEmployee())
            {
                Console.WriteLine("{0} {1} {2} {3}", emp2.id, emp2.name, emp2.salary, emp2.address);
            }

            Employee emp3 = mokeEmployeeRepositry.Update(new Employee { id = 3, name = "Rohit", salary = 45678, address = "Rohta", }) ;
            Console.WriteLine("{0} {1} {2} {3}", emp3.id, emp3.name, emp3.salary, emp3.address);

            Console.WriteLine("=================================");

            foreach (Employee emp4 in mokeEmployeeRepositry.GetAllEmployee())
            {
                Console.WriteLine("{0} {1} {2} {3}", emp4.id, emp4.name, emp4.salary, emp4.address);
            }
        }
    }
}