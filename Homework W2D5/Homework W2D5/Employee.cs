using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W2D5
{
    public class Employee
    {
        string empName;
        string empEmail;
        string empReview;
        bool empSatisfactory;
        Int64 empPhone;
        double empSalary;
        Department empDepart;

        public string EmpName
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }
        }
        public string EmpEmail
        {
            get
            {
                return empEmail;
            }

            set
            {
                empEmail = value;
            }
        }
        public string EmpReview
        {
            get
            {
                return empReview;
            }

            set
            {
                empReview = value;
            }
        }
        public bool EmpSatisfactory
        {
            get
            {
                return empSatisfactory;
            }

            set
            {
                empSatisfactory = value;
            }
        }
        public Int64 EmpPhone
        {
            get
            {
                return empPhone;
            }

            set
            {
                empPhone = value;
            }
        }
        public double EmpSalary
        {
            get
            {
                return empSalary;
            }

            set
            {
                empSalary = value;
            }
        }

        public Department EmpDepart
        {
            get
            {
                return empDepart;
            }

            set
            {
                empDepart = value;
            }
        }

        public Employee()
        { }

        public void empRaise(double percent)
        {
            this.EmpSalary = EmpSalary + (EmpSalary * percent / 100);
        }
        
        public void deptRaise(List<Employee> employeeList, double percent)
        {
            for (int e = 0; e > employeeList.Count; e++)
            {
                if (employeeList[e].EmpSatisfactory == true)
                {
                    Console.WriteLine("Applying salary increase to {0}'s current salary of {1}.", employeeList[e].EmpName, employeeList[e].EmpSalary);
                    this.EmpSalary = EmpSalary + (EmpSalary * percent / 100);
                    Console.WriteLine();
                    Console.WriteLine("{0]'s new salary: {1}", employeeList[e].EmpName, employeeList[e].EmpSalary);
                    System.Threading.Thread.Sleep(3000);
                }
            }
        }
    }
}
