using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W2D5
{
    class Employee
    {
        string empName;
        string empEmail;
        string empReview;
        bool empSatisfactory;
        int empPhone;
        double empSalary;
        Department empDepart;

        public Employee()
        { }

        public void empRaise(double percent)
        {
            this.empSalary = empSalary + (empSalary * percent);
        }

        public void empReviewCreate(string mainEmpReview, bool mainEmpSatis)
        {
            this.empReview = mainEmpReview;
            this.empSatisfactory = mainEmpSatis;
        }
    }
}
