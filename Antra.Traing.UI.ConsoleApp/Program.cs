using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Traing.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ask a = new ask();
            a.greet();
            int answer=Convert.ToInt32(Console.ReadLine());
            Customer customer = null;
            switch (answer)
            {
                case 1:
                    customer = new BronzeCustomer();
                    break;
                case 2:
                    customer = new SilverCustomer();
                    break;
                case 3:
                    customer = new GoldCustomer();
                    break;
                case 4:
                    customer = new PlatinumCustomer();
                    break;
            }
            customer.AddCustomer();
            customer.PrintCustomer();
                
            Console.Read();
        }
    }
}
