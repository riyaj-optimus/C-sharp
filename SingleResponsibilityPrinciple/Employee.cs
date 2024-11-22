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

        public Ilogger logger;

        public Employee(Ilogger logger)
        {
            logger = logger;
        }

        public void Save(Employee empp)
        {
            //we will write our code in try catch block because if any exception occurs while saving the data , 
            //it need to be logged
            try
            {
                throw new Exception();
            }
            catch(Exception e)
            {

                //var isFileLoggingEnabled = true;
                //var isDataBaseLoggingEnabled = false;

                //if (isFileLoggingEnabled)
                //{
                //    Ilogger logg = new FileLogger();
                //    logg.LogError(e.Message);
                //}
                //if(isDataBaseLoggingEnabled)
                //{

                //    Ilogger logg = new FileLogger();
                //    logg.LogError(e.Message);
                //}

                //here the emplyee class is taking the responsibility of selecting the logging mechanism and also
                //the new keyword is being used for tightly coupling->worst design

                //Logger lg = new Logger();
                //logger class and emplyee class are tightly coupled:
                //but tigght coupling is not preferred so we will remove this new keywoerd(tight coupling) with the help of dependency injection
                //lg.LogError(e.Message); 
                //but the problem here is we can not add the log error message in any other file except the mentioned one
                //what if i want to save  the log error message in the database.


                logger.LogError(e.Message);
            }


        }

      

         
    }
    public enum EmpType
    {
        partTime, fullTime , Contractor, Clevel
    }


}
