

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

      public interface IStockOption: IEmployeeFinances
      {
            double CalculateStock(Employee emp);
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

    public class EmployeeFinnaceFprCLevel : IStockOption
    {
        public double CalculatePay(Employee emp)
        {
            return 30;
        }
        public double CalculateRewards(Employee emp)
        {
            return 30;
        }

        public double CalculateStock(Employee emp)
        {
            return 30;
        }
    }
}

//for cases of interface segrregation  : the classes for FTE and PTE do not really recquires to implement the stock option but if thwy dont the classes for FTE and PTE will throw error of method not implementing , 
//so here arises the need of interface segregation