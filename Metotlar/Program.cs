﻿//Dont repeat yourself -- Clean code -- Best Pratice

using Methods;

Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] {urun1, urun2};


//type-safe -- tip güvenli
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("--------------------");

    

    
}
Console.WriteLine("----------------Methods-------------");
//instance - örnek
//encapsulation
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("Armut", "Yeşil armut", 12, 2);
sepetManager.Ekle2("Elma", "Yeşil Elma", 13, 3);
sepetManager.Ekle2("Karpuz", "Diyarbakır", 11, 5);




