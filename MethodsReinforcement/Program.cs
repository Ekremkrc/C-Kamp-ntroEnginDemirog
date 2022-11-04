using System.ComponentModel.DataAnnotations;

//Add();
//Add();
//Add();
//Add();
//var result = Add2(20,30);

//int number1 = 20;
//int number2=100;
//var result2 = Add3(ref number1,number2);
//Console.WriteLine(result2);  

//Console.WriteLine(result);
//Console.ReadLine();
Console.WriteLine(Multiply(2,4));


static void Add() 
{
    Console.WriteLine("Added!!");  // Cwnin içindeki "Added!!" yazını değiştirirsem tüm Add(); için geçerli olacak
                                   //void emir verir git şunu yap gibi.
}
    
    
static int Add2(int number1, int number2=30) //Paremetreli metot
{                                            //number2=30 dediğimiz zaman number2 ye değer girilmezse default olarak 30 alır.
      var result = number1 + number2;
      return result;

}
//ref'de değişkene main'de bir değer atayıp fonksiyona göndermeniz gerekir eğer fonksiyonda değişkene farklı bir değer belirlenmişse mainde'de fonksiyondaki değer gözükür 
//out'da sistem aynıdır ancak değişkene mainde bir değer vermenize gerek yoktur fonksiyonun içindeki değeri alır ve mainde kullanır

static int Add3(ref int number1, int number2)//**ref** 
{                                            //**out** 
    number1 = 30; 
    return number1 + number2;
}
static int Multiply(int number1, int number2)//**Overloading** Metotların aşırı yüklenmesi. Metodun imzası. Çarpma.
{
    return  number1 * number2;
}
static int Add4(params int[] numbers)//Metodumuza aynı tipte istediğimiz kadar değer gönderebiliriz.
{
    return numbers.Sum();
}