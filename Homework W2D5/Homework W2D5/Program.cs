using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W2D5
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool programActive = true;
            bool empCreated = false;

            while (programActive)
            {
                double percent = 0;

                Console.WriteLine(empCreated);
                Console.WriteLine(Employeelist[0]);
            }
        }
        //public void reviewEmployee(List<Employee> employeeList)
        //{
        //    foreach (Employee emp in List<Employee>employeeList)
        //    {
        //        Console.WriteLine(employeeList[emp]);
        //    }
        //}
        public void CreateEmployee(ref bool empCreated, List<Employee> EmployeeList)
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
