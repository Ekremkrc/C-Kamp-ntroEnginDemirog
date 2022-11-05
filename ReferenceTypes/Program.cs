//int,decimal,float,enum,boolean value types değer tipler
int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2;
sayi2 = 100;
//Console.WriteLine("Sayı 1 : " + sayi1);// sayi1=20dir

//arrays,class,interface ... reference types
int[] sayilar1 = new int[] {1,2, 3};
int[] sayilar2 = new int[] {10,20,30};

sayilar1 = sayilar2;
sayilar2[0] = 1000;


Person person1=new Person();
Person person2=new Person();

person1.FirstName = "Ekrem";
person2 = person1;

person1.FirstName = "Berkay";

//Console.WriteLine(person2.FirstName);


Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditNumber = "32134214124";
Employes employes = new Employes();


Person person3 = customer;
customer.FirstName = "Ahmet";

PersonManager personManager = new PersonManager();
personManager.Add(customer);

//Console.WriteLine(((Customer)person3).CreditNumber);




//base class
class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string CreditNumber { get; set; }
}

class Employes:Person
{
    public int EmployeeNumber { get; set; }
}
class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName);
    }
        

        
}
