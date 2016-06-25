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
        int empPhone;
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
        public int EmpPhone
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

        public Employee()
        { }

        public void empRaise(double percent)
        {
            this.EmpSalary = EmpSalary + (EmpSalary * percent);
        }

        public void empReviewCreate(string mainEmpReview, bool mainEmpSatis)
        {
            this.EmpReview = mainEmpReview;
            this.EmpSatisfactory = mainEmpSatis;
        }
    }
}
