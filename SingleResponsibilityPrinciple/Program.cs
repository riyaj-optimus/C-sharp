using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee empFTE = new Employee(new FileLogger()) { EmployeeType = EmpType.fullTime.ToString(), TotalHours = 10 };
            Employee empPTE = new Employee(new FileLogger()) { EmployeeType = EmpType.partTime.ToString(), TotalHours = 10 };
            Employee empContractor = new Employee(new FileLogger()) { EmployeeType = EmpType.Contractor.ToString(), TotalHours = 10 };

            empFTE.Save(empFTE);

            Console.Read();


        }
    }
}
