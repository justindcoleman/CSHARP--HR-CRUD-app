using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W2D5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programActive = true;
            bool empCreated = false;
            Employee tempEmp = new Employee();

            List<Employee> employeeList = new List<Employee>();

            while (programActive)
            {
                double percent = 0;

                Console.WriteLine(empCreated);
                CreateEmployee(ref empCreated, employeeList);
                //int employeeListLength = employeeList.Count;
                for (int e = 0; e < employeeList.Count; e++)
                {
                    Console.WriteLine(employeeList[e].EmpName);
                }
                //foreach (Employee e in employeeList)
                //{

                //    Console.WriteLine(employeeList[e.EmpName]);
                //}

            }

        }
        //public void reviewEmployee(List<Employee> employeeList)
        //{
        //    foreach (Employee emp in List<Employee>employeeList)
        //    {
        //        Console.WriteLine(employeeList[emp]);
        //    }
        //}
        static void CreateEmployee(ref bool empCreated, List<Employee> EmployeeList)
        {
            Employee newEmp = new Employee();
            Console.WriteLine("Employee first and last name: ");
            string name = Console.ReadLine();
            newEmp.EmpName = name;
            EmployeeList.Add(newEmp);
            //more stuff
            empCreated = true;
        }

    }
}
