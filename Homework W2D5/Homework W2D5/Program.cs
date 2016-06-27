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
            Department tempDept = new Department();

            List<Employee> employeeList = new List<Employee>();
            List<Department> departmentList = new List<Department>();


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
                            CreateDepartment(departmentList);
                            break;
                        case 3:
                            ;
                            for (int e = 0; e < employeeList.Count; e++)   //for loop that prints employee list
                            {
                                Console.WriteLine();
                                Console.WriteLine("{0} - {1}", e, employeeList[e].EmpName);
                            }
                            int userEmpRevChoice = Convert.ToInt32(Console.ReadLine());
                            if (userEmpRevChoice <= employeeList.Count)
                            {
                                Console.WriteLine("Employee {0}\nCurrent Satifaction status: {1}\nEmployee review history:\n{2}", employeeList[userEmpRevChoice].EmpName, employeeList[userEmpRevChoice].EmpSatisfactory, employeeList[userEmpRevChoice].EmpReview);
                                Console.WriteLine("Employee is satisfactory(t/f): ");
                                string userEmpRevSatis = Console.ReadLine();
                                string userEmpRevSatisLower = userEmpRevSatis.ToLower();
                                if (userEmpRevSatisLower == "true" || userEmpRevSatisLower == "t")
                                {
                                    employeeList[userEmpRevChoice].EmpSatisfactory = true;
                                    Console.WriteLine("Write employee review:\n");
                                    string userEmployeeActualReview = Console.ReadLine();
                                    employeeList[userEmpRevChoice].EmpReview = userEmployeeActualReview;
                                }
                                else if (userEmpRevSatisLower == "false" || userEmpRevSatisLower == "f")
                                {
                                    employeeList[userEmpRevChoice].EmpSatisfactory = false;
                                    Console.WriteLine("Write employee review:\n");
                                    string userEmployeeActualReview = Console.ReadLine();
                                    employeeList[userEmpRevChoice].EmpReview = userEmployeeActualReview;
                                }

                                else
                                Console.WriteLine("Pick true or false.");
                            }

                            else
                                Console.WriteLine("Pick an actual employee, genius.");

                            Console.WriteLine("review employee not yet fully implemented");
                            //unsure how to let user choose from a list that i don't know the extent of. maybe i can use an employee id as a constant
                            //and somehow they choose that?  but i'm still not sure how to set up actions for an unknown number of choices.
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
                                Console.WriteLine("Employee's department is: {0}", employeeList[e].EmpDepart.DeptName);

                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                            }
                            break;
                        case 5:
                            for (int d = 0; d < departmentList.Count; d++)   //for loop that prints department list
                            {
                                Console.WriteLine();
                                Console.WriteLine("Department name: {0}", departmentList[d].DeptName);

                                Console.WriteLine("Press any key to continue");
                                Console.ReadLine();
                            }
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

            Console.WriteLine("Employee's department: ");
            Department dept = new Department();
            dept.DeptName = Console.ReadLine();
            newEmp.EmpDepart = dept;

            newEmp.EmpSatisfactory = true;
            newEmp.EmpReview = "";


            EmployeeList.Add(newEmp);
            empCreated = true;
        }
        static void CreateDepartment(List<Department> departmentList)
        {
            Department newDept = new Department();
            Console.WriteLine("Department Name: ");
            string name = Console.ReadLine();
            newDept.DeptName = name;

            departmentList.Add(newDept);
        }
        static void MakeMenu()
        {
            Console.WriteLine("Choose an option: \n1. Create an employee\n2. Create a department\n3. Review an employee\n4. Display all employees\n5. Display all department\n6. Give raise\n7. Quit program");
        }
        static bool ContinueProgram(ref bool programActive)
        {// this is in need of error handling.  probably tolower then char conversion.
            Console.WriteLine("Do you want to quit?");
            string quitAnswer = Console.ReadLine();
            if (quitAnswer == "y")
                return programActive = false;
            else
                return programActive = true;
        }
    }
}
