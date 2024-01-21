using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.PhoneAbonentProject.Classes
{
    internal class BillingHistory
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }

        public void ShowBillingHistory()
        {
            Console.WriteLine($"Payment Date: {Date}, Amount: {Amount}, Description: {Description}");
        }
    }
}
