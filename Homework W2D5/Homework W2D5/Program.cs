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
                                Console.WriteLine();
                                Console.WriteLine("Employee name: {0}", employeeList[e].EmpName);
                                Console.WriteLine("Employee email address: {0}", employeeList[e].EmpEmail);
                                Console.WriteLine("Employee phone number: {0}", employeeList[e].EmpPhone);
                                Console.WriteLine("Employee salary: {0}", employeeList[e].EmpSalary);
                                Console.WriteLine("Employee is Satisfactory: {0}", employeeList[e].EmpSatisfactory);
                                Console.WriteLine("Employee reviews:\n{0}", employeeList[e].EmpReview);
                                Console.WriteLine("Employee's department is: {0}", employeeList[e].EmpDepart);

                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
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

                            ContinueProgram(ref programActive);
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
        {//a whole bunch of error handling is probably needed here.  also a way to back out and/or head backwards would be nice to add.
            Employee newEmp = new Employee();
            Console.WriteLine("Employee first and last name: ");
            string name = Console.ReadLine();
            newEmp.EmpName = name;

            Console.WriteLine("Employee email address: ");
            string email = Console.ReadLine();
            newEmp.EmpEmail = email;

            Console.WriteLine("Employee phone number: ");
            Int64 phoneNumber = Convert.ToInt64(Console.ReadLine()); //this is an iffy implmentation, will change later if i have the time
            newEmp.EmpPhone = phoneNumber;

            Console.WriteLine("Employee starting salary: ");
            double salary = Convert.ToInt64(Console.ReadLine()); //this is an iffy implmentation, will change later if i have the time
            newEmp.EmpSalary = salary;

            newEmp.EmpSatisfactory = true;
            newEmp.EmpReview = "";


            EmployeeList.Add(newEmp);
            empCreated = true;
        }
        static void MakeMenu()
        {
            Console.WriteLine("Choose an option: \n1. Create an employee\n2. Create a department\n3. Review an employee\n4. Display all employees\n5. Display all department\n6. Give raise\n7. Quit program");
        }
        static bool ContinueProgram(ref bool programActive)
        {// this is in need of error handling.  probaly .tolower then char conversion.
            Console.WriteLine("Do you want to quit?");
            string quitAnswer = Console.ReadLine();
            if (quitAnswer == "y")
                return programActive = false;
            else
                return programActive = true;
        }
    }
}
