using ClassMethodDemo;

Customer customer1 = new Customer();
customer1.Id = 1;
customer1.Name = "Metin";
customer1.Surname = "Karaca";

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.Name = "Fatma";
customer2.Surname = "Karaca";

Customer customer3 = new Customer();
customer3.Id = 3;
customer3.Name = "Mert";
customer3.Surname = "Karaca";

Customer customer4 = new Customer();
customer4.Id = 4;
customer4.Name = "Bahadır";
customer4.Surname = "Karaca";

Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

CustomerManager customerManager = new CustomerManager();

foreach (Customer customer in customers)
{
    customerManager.Add(customer); //Ekle
    customerManager.Remove(customer); //Sil
    customerManager.Get(customer); //Listele
    Console.WriteLine("------------");

}