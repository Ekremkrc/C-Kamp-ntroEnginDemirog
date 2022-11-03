Urun Urun1 = new Urun();
Urun1.Urunİsim = "Kalem";
Urun1.UrunRenk = "Beyaz";
Urun1.UrunFiyat = 1.5;

Urun Urun2 = new Urun();
Urun2.Urunİsim = "Silgi";
Urun2.UrunRenk = "Mor";
Urun2.UrunFiyat = 1;

Urun Urun3 = new Urun();
Urun3.Urunİsim = "Tükenmez Kalem";
Urun3.UrunRenk = "Turuncu";
Urun3.UrunFiyat = 2.5;

Urun[] malzemeler = new Urun[] { Urun1, Urun2, Urun3 };


foreach (var Urun in malzemeler)
{
    Console.WriteLine(Urun.Urunİsim + " : " + Urun.UrunRenk + " - " + Urun.UrunFiyat);
}






class Urun
{
    public string Urunİsim { get; set; }
    public string UrunRenk { get; set; }
    public double UrunFiyat { get; set; }
}





class Product
{
    public string ProductName { get; set; }
    public string ProductColor { get; set; }
    public double ProductPrice { get; set; }
}
