using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _15.PhoneAbonentProject.Classes
{
    internal class Subscriber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public List<BillingHistory> BillingHistory { get; set; }
        public TariffPlan TariffPlan { get; set; }

        public void ShowSubscriberInfo()
        {
            Console.WriteLine($"Subscriber ID: {Id}");
            Console.WriteLine($"Subscriber Name: {Name}");
            Address.ShowAddressInfo();
            TariffPlan.ShowTariffPlan();

            Console.WriteLine("Billing History:");
            foreach (var history in BillingHistory)
            {
                history.ShowBillingHistory();
            }

            Console.WriteLine(new string('-', 40));
        }

    }
}
