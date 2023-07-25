using System;
using System.Collections.Generic;
using System.Text;

namespace AdressbookSystem
{
    internal class Manage
    {
        public void CreateContact()
        {
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Enter adress:");
            var adress = Console.ReadLine();
            Console.WriteLine("Enter city:");
            var city = Console.ReadLine();
            Console.WriteLine("Enter state:");
            var state = Console.ReadLine();
            Console.WriteLine("Enter zipcode:");
            var zipcode = Console.ReadLine();
            Console.WriteLine("Enter phonenum:");
            var phonenum = Console.ReadLine();
            List<AdressBook> details = new List<AdressBook>() {
            new AdressBook(firstName, lastName, adress, city, state, zipcode, phonenum)};
            foreach (var value in details)
            {
                Console.WriteLine(value.FirstName+" "+value.LastName + " " + value.adress + " " + value.city + " " + value.state + " " + value.zipcode + " " + value.phonenum);
            }
        }
      }
}
