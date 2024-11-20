

using System;
namespace SingleResponsibilityPrinciple
{
     public class Logger
    {
        public void LogError(string mssg)
        {
            System.IO.File.WriteAllText("C://log.txt", mssg);
        }
    }
}