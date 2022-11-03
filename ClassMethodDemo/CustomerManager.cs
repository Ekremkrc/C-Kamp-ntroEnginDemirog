using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " İsimli kişi müşteri listenize eklendi.");
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " İsimli kişi müşteri listenizden silinmiştir.");
        }
        public void Get(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id + ", Ad:" + customer.Name + ", Soyad: " + customer.Surname);
        }

    }
}
