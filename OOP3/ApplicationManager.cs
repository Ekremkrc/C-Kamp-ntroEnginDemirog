using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        // Method Injection
        public void MakeApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            // Başvuran bilgilerini değerlendirme.
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();

            }
        }
        public void MakeCreditPreview(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }


    }
}
