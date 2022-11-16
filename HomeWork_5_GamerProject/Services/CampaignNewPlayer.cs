using HomeWork_5_GamerProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_GamerProject.Services
{
    internal class CampaignNewPlayer : ICampaignService
    {
        public double Discount(double Price)
        {
            double discount = (Price / 100) * 10;
            double total = Price - discount;
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Yeni Oyuncu indirimi yapıldı. İndirim Tutarı: -{0} TL", discount);
            Console.WriteLine("Yeni Oyuncu indiriminiz başarıyla uygulandı.");
            return total;
        }
    }
}
