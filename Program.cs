using System;
using System.Collections.Generic;
using System.Transactions;

namespace AdressbookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AdressBook> details = new List<AdressBook>();
            Console.WriteLine("Enter the value");
            Console.WriteLine("1.Add contact to adressbook 2.Edit existing contact 3.Delete contact 4.Add multiple contacts");
            int ch =Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:Console.WriteLine("Add contact");
                    Manage mg = new Manage();
                    mg.CreateContact();
                       break;
                case 2:Console.WriteLine("Edit existing contact");
                       break;
                case 3:Console.WriteLine("Delete contact");
                       break;
                case 4:Console.WriteLine("Add multiple contacts");
                       break;
                   
                
            }
        }
    }
}
