using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp06
{
    class TestClassOne
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }

        public TestClassOne(string name, int age, string address, string phoneNumber, string city, string region, string country, string postalCode, string email)
        {
            Name = name;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
            Email = email;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"Region: {Region}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Postal Code: {PostalCode}");
            Console.WriteLine($"Email: {Email}");
        }

    }
}
