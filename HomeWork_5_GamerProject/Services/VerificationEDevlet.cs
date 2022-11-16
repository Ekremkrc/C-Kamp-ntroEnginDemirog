using HomeWork_5_GamerProject.Interfaces;
using HomeWork_5_GamerProject.Props;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_GamerProject.Services
{
    internal class VerificationEDevlet : IVerificationService
    {
        public void CheckInformation(Player player)
        {
            if (player.FirstName.Length >= 3 && player.LastName.Length >= 3 && player.TCNumber.Length == 11 && player.BirthYear > 1859)
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " E-Devlet Kimlik doğrulamasından geçti.");
            }
            else
            {
                Console.WriteLine(player.FirstName + " " + player.LastName + " E-Devlet Kimlik doğrulamasından geçemedi.");

            }
        }
    }
}
