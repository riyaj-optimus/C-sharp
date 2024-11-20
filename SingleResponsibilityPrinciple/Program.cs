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
            Employee ef = new Employee()
            {
                EmployeeType = EmpType.fullTime.ToString(),
                TotalHours = 10,
            };
            Employee ep = new Employee()
            {
                EmployeeType = EmpType.partTime.ToString(),
                TotalHours = 5,
            };

            Employee ec = new Employee()
            {
                EmployeeType = EmpType.Contractor.ToString(),
                TotalHours = 25,
            };

            IEmployeeFinances finances = new EmployeeFinancesForFTE();

            var totalPayfte = finances.CalculatePay(ef);
            var totalRewardsfte = finances.CalculateRewards(ef);
            Console.WriteLine("Total rewards for the full Time Employees are : "+ totalRewardsfte);
            Console.WriteLine("Total Pay of fullTime employee : "+totalPayfte);
            Console.WriteLine();

            IEmployeeFinances financespte = new EmployeeFinancesForPTE();

            var totalPaypte = financespte.CalculatePay(ep);
            var totalRewardspte = financespte.CalculateRewards(ep);
            Console.WriteLine("Total rewards for the full Time Employees are : " + totalRewardspte);
            Console.WriteLine("Total Pay of partTime employee : " + totalPaypte);
            Console.WriteLine();

            IEmployeeRewards finance = new EmployeeFinancesForContractor();

           
            var totalRewards = finance.CalculateRewards(ep);
            Console.WriteLine("Total rewards for the full Time Employees are : " + totalRewards);
            Console.WriteLine();

            Console.Read(); 


        }
    }
}
