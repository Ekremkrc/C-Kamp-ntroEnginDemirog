using OoP2;
using System.Reflection.Metadata.Ecma335;

Individual customer1 = new Individual();
customer1.ID = 1;
customer1.CustomerNo = "12345";
customer1.Name = "Berkay";
customer1.LastName = "Karaca";
customer1.CitizenshipNumber = "12345678910";

Coorporate custumer2 = new Coorporate();
custumer2.ID = 2;
custumer2.CustomerNo = "412441";
custumer2.CompanyName = "Kodlama.io";
custumer2.TaxNo = "123213";

Customer customer3 = new Individual();
Customer customer4 = new Coorporate();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(custumer2);
    



//Gerçek müşteri - Tüzel Müşteri
//SOLID


    