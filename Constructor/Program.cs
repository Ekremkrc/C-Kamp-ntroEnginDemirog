
Customer customer1 = new Customer(1,"Berkay","Karaca","Ankara");


Console.WriteLine(customer1.FirstName);



class Customer
{
   
    
    //default Constructor
    public Customer(int id, string firstName, string lastName, string city)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }
    
    
    
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}







