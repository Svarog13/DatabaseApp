using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PhoneAbonentProject.Classes
{
    internal class TariffPlan
    {
        public string Name { get; set; }
        public decimal MonthlyFee { get; set; }
        public string Description { get; set; }

        public void ShowTariffPlan()
        {
            Console.WriteLine($"Tariff Plan: {Name}, Monthly Fee: {MonthlyFee}, Description: {Description}");
        }
    }
}
