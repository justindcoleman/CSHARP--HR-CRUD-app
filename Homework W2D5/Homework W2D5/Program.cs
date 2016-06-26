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

                MakeMenu();
                string userMenuChoice = Console.ReadLine();
                int menuChoiceInt;
                bool menuChoiceBool = int.TryParse(userMenuChoice, out menuChoiceInt);
                if (menuChoiceBool == true)
                {
                    switch (menuChoiceInt)
                    {
                        case 1:
                            CreateEmployee(ref empCreated, employeeList);
                            break;
                        case 2:
                            Console.WriteLine("create department not yet implmented");
                            break;
                        case 3:
                            Console.WriteLine("review employee not yet implmented");
                            break;
                        case 4:
                            for (int e = 0; e < employeeList.Count; e++)   //for loop that prints employee list
                            {
                                Console.WriteLine(employeeList[e].EmpName);
                            }
                            break;
                        case 5:
                            Console.WriteLine("list all departments not yet implmented");
                            //for (int d = 0; d < XXXX.Count; d++)   //for loop that prints department list
                            //{
                            //    Console.WriteLine(XXXX[d].deptName);
                            //}
                            break;
                        case 6:
                            Console.WriteLine("give raise not yet implmented");
                            //should include an if/else statment for "just X employee" or "all satisfactory employees in X dept"
                            break;
                        case 7:
                            
                            ContinueProgram(programActive);
                            break;
                        default:
                            break;
                    }


                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Why do you think it's acceptable to enter anything other than a number?");
                    Console.WriteLine();
                }
            }
        }

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
        static void MakeMenu()
        {
            Console.WriteLine("Choose an option: \n1. Create an employee\n2. Create a department\n3. Review an employee\n4. Display all employees\n5. Display all department\n6. Give raise\n7. Quit program");
        }
        static bool ContinueProgram(bool programActive)
        {
            Console.WriteLine("Do you want to keep working? (y/n)");
            string answer = Console.ReadLine();
            if (answer != "y")
                return programActive = false;
            else
                return programActive = true;
        }
    }
}
