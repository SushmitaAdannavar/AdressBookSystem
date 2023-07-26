using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Transactions;

namespace AdressbookSystem
{
    public class Program
    {
        public static List<Person> People = new List<Person>();
        public static void Main(string[] args)
        {   while (true)
            {
                Console.WriteLine("Enter the value");
                Console.WriteLine("1.Add contact to adressbook 2.Edit existing contact 3.Delete contact 4.Add multiple contacts ");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Add contact");
                        Manage.CreateContact();
                        break;
                    case 2:
                        Console.WriteLine("Edit existing contact");
                        Manage.UpdateContact();
                        break;
                    case 3:
                        Console.WriteLine("Delete contact");
                        break;
                    case 4:
                        Console.WriteLine("Add multiple contacts");
                        break;
                    case 5:goto L40;


                }
            }L40: Console.WriteLine("End of program");
            
        }
    }
}
