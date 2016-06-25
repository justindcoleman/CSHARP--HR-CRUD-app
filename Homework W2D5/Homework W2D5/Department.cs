using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_W2D5
{
    public class Department
    {
        string deptName;

        List<Employee> employeeList = new List<Employee>();

        public string DeptName
        {
            get
            {
                return deptName;
            }

            set
            {
                deptName = value;
            }
        }
        public List<Employee> EmployeeList
        {
            get
            {
                return employeeList;
            }

            set
            {
                employeeList = value;
            }
        }
    }
}
