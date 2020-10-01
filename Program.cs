using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            var employee = new Employee("Joe", "Blow", 0);
            var employee1 = new Employee("Joe", "shmow", 1);
            var employee2 = new Employee("Billy", "Bob", 2);
            var employee3 = new Employee("Mary", "Jane", 3);
            var employee4 = new Employee("Peter", "Parker", 4);
            var employee5 = new Employee("Richard", "Rhaul", 5);
            var employee6 = new Employee("Tony", "Stark", 6);
            var employee7 = new Employee("Cloud", "Strife", 7);
            var employee8 = new Employee("Tifa", "Lockheart", 8);
            var employee9 = new Employee("Steve", "Rogers", 9);

            employees.Add(employee);
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);

            
            //List<Employee> JoeList = new List<Employee>();
            //foreach (Employee emp in employees)
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        JoeList.Add(emp);
            //        Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //    }
            //}

            //List<Employee> JoeList2 = employees.Where(x => x.FirstName == "Joe").ToList();

            //foreach(Employee emp in JoeList2)
            //{
            //    Console.WriteLine(emp.FirstName + " " + emp.LastName);
            //}

            List<Employee> idnum = employees.Where(x => x.Id > 5).ToList();
            foreach(Employee emp in idnum)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName + " " + emp.Id);
            }
            Console.ReadLine();


        }
    }
}
