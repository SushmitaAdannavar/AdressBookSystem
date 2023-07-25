using System;
using System.Collections.Generic;
using System.Transactions;

namespace AdressbookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            Console.WriteLine("1.Add person to adressbook 2.Edit existing person 3.Delete person 4.Add multiple persons");
            int ch =Convert.ToInt32(Console.ReadLine());
            switch(ch)
            {
                case 1:Contact ab = new Contact();
                      ab.CreatePerson();
                      break;
                case 3:Contact ab1 = new Contact(); 
                      ab1.RemovePersonFromList();
                      break;

            }
        }
    }
}
