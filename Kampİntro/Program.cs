// See https://aka.ms/new-console-template for more information
//type safety - tip güvenliği
//do not repat yourself - Kendini tekrarlama
//değer tutucu


string KategoriEtiketi = "Kategori";
int ogrencisayisi = 32000;
double KarPayı = 1.45;
bool SistemeGirisYapmismi = false;
double dolarDun = 1.35;
double dolarBugun = 1.45;


if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış Oku");
}
else if (dolarBugun<dolarDun)
{
    Console.WriteLine("Artıs Oku");
}
else
{
    Console.WriteLine("Degişmedi Oku");
}



if (SistemeGirisYapmismi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");

}
else
{
    Console.WriteLine("Giriş yap butonu");
}



Console.WriteLine(KategoriEtiketi);



