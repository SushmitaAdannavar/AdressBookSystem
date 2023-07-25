using System;
using System.Collections.Generic;
using System.Text;

namespace AdressbookSystem
{
    public class AdressBook
    {
        public string FirstName
        {get;set;}
        public string LastName
        { get; set; }
        public string adress
        { get; set; }
        public string city
        { get; set; }
        public string state
        { get; set; }
        public string zipcode
        { get; set; }
        public string phonenum
        { get; set; }
        public AdressBook(string firstName,string lastName,string adress,string city,string state, string zipcode,string phonenum)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.adress = adress;
            this.city = city;
            this.state = state;
            this.zipcode = zipcode;
            this.phonenum = phonenum;
        }
       
        

    }
}
