using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PhoneAbonentProject.Classes
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public void ShowAddressInfo()
        {
            Console.WriteLine($"Abonent lives at Address: {City}, {Street}, {House}, {Apartment}");
        }
    }

}
