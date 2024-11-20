using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
     public class Employee
    {
        public string EmployeeType{ get;set;}
        public double TotalHours { get; set; }

        public void Save(Employee empp)
        {
            //we will write our code in try catch block because if any exception occurs while saving the data , 
            //it need to be logged
            try
            {

            }
            catch(Exception e)
            {
                Logger lg = new Logger();
                //logger class and emplyee class are tightly coupled:
                //but tigght coupling is not preferred so we will remove this new keywoerd(tight coupling) with the help of dependency injection
                lg.LogError(e.Message); 
                //but the problem here is we can not add the log error message in any other file except the mentioned one
                //what if i want to save  the log error message in the database.

            }


        }

      

         
    }
    public enum EmpType
    {
        partTime, fullTime , Contractor
    }


}
