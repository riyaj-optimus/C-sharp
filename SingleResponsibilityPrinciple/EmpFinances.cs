

using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple
{
    public interface IEmployeeRewards
    {
        double CalculateRewards(Employee emp);
    }

    public interface IEmployeeFinances : IEmployeeRewards
    {
        double CalculatePay(Employee emp);
    }

  
    


    public class EmployeeFinancesForFTE : IEmployeeFinances
    {
        public  double CalculatePay(Employee emp)
        {
            return emp.TotalHours * 10;
        }

        public  double CalculateRewards(Employee emp)
        {
            return 200;
        }

    }

    public class EmployeeFinancesForPTE : IEmployeeFinances
    {
        public  double CalculatePay(Employee emp)
        {
            return emp.TotalHours * 5;
        }

        public  double CalculateRewards(Employee emp)
        {
            return 150;
        }
    }

    public class EmployeeFinancesForContractor : IEmployeeRewards
    {

        public  double CalculateRewards(Employee emp)
        {
            return 120;
        }
    }
}
