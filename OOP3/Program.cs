using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Interfaceler onu implement eden classın referans numarasını tutabilir.
            ICreditManager creditManagerPF = new CreditManagerPersonalFinance();
            ICreditManager creditManagerTransport = new CreditManagerTransport();
            ICreditManager creditManagerMortgage = new CreditManagerMortgage();
            
            
            ILoggerService fileBaseLogerService = new FileBaseLoggerService();
            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileBaseLoggerService() };


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new CreditManagerArtisan(), loggers);


            List<ICreditManager> credits = new List<ICreditManager>() {creditManagerPF, creditManagerTransport };
            
            //applicationManager.MakeCreditPreview(credits); 



        }
    }
}