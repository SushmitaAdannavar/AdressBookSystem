using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AdressbookSystem
{
    public class Manage
    {
        public static List<Person> People = new List<Person>();
        public static void CreateContact()
        {
            Person person = new Person();
            Console.WriteLine("Enter firstName:");
            person.FirstName = Console.ReadLine();
            Console.WriteLine("Enter lastName:");
            person.LastName = Console.ReadLine();
            Console.WriteLine("Enter adress:");
            person.adress = Console.ReadLine();
            Console.WriteLine("Enter city:");
            person.city= Console.ReadLine();
            Console.WriteLine("Enter state:");
            person.state = Console.ReadLine();
            Console.WriteLine("Enter zipcode:");
            person.zipcode = Console.ReadLine();
            Console.WriteLine("Enter phonenum:");
            person.phonenum = Console.ReadLine();
            People.Add(person);
            PrintPeople();
        }
        public static void PrintPeople()
        {
            foreach(var person in People)
            Console.WriteLine(person.FirstName + " " + person.LastName + " " + person.adress + " " +person.city + " " + person.state + " " + person.zipcode + " " + person.phonenum);
        }
        public static void UpdateContact()
        {
            Console.WriteLine("Which information has to be updated? 1.FirstName 2.LastName 3.adress 4.city 5.zipcode 6.phonenum");
            string userOption =Console.ReadLine();
            Console.WriteLine("Enter updated data");
            string newdata = Console.ReadLine();
            Console.WriteLine("Enter firstname of existing user to be updated");
            var oldFirstName = Console.ReadLine();
            var updated =People.Where(x => x.FirstName == oldFirstName);
            if (userOption == "Firstname") { foreach (var value in updated) { value.FirstName = newdata; } }
            else if (userOption == "Lastname") { foreach (var value in updated) { value.LastName = newdata; } }
            else if (userOption == "adress") { foreach (var value in updated) { value.adress = newdata; } }
            else if (userOption == "city") { foreach (var value in updated) { value.city = newdata; } }
            else if (userOption == "zipcode") { foreach (var value in updated) { value.zipcode = newdata; } }
            else if (userOption == "phonenum") { foreach (var value in updated) { value.phonenum = newdata; } }
            else { Console.WriteLine("Invalid input"); }
            PrintPeople();
            
        }  
        public static void DeleteContact()
        {
            Console.WriteLine("Enter the first name of the person you would like to remove.");
            string firstName = Console.ReadLine();
            Person person1 = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
            People.Remove(person1);
            PrintPeople();
        }
    }
}
