

using System;
namespace SingleResponsibilityPrinciple
{

    public interface Ilogger {
        void LogError(string mssg);

    }

   

    public class FileLogger : Ilogger
    {
        public void LogError(string mssg)
        {
            //System.IO.File.WriteAllText("C://log.txt", mssg);
            Console.WriteLine("Logging into the File");
        }
    }

    public class DataBaseLogger : Ilogger
    {
        public void LogError(string mssg)
        {
            //System.IO.File.WriteAllText("C://log.txt", mssg);
            Console.WriteLine("Logging into the Database");
        }
    }
}