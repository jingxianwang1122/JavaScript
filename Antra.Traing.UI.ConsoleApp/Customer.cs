using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Traing.UI.ConsoleApp
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Mobile { get; set; }

        public virtual void AddCustomer() 
        { 
            Console.WriteLine("Enter Id->");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name->");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Mobile->");
            Mobile = Console.ReadLine();
        }

        public virtual void PrintCustomer()
        {
            Console.WriteLine("--------------------info--------------");
            Console.WriteLine("Id="+Id);
            Console.WriteLine("Name="+Name);
            Console.WriteLine("Mobile="+Mobile);
                
        }
    }

    class BronzeCustomer : Customer
    {
        string level = "Bronze";
        public override void AddCustomer()
        {
            base.AddCustomer();
            
        }

        public override void PrintCustomer()
        {
            Console.WriteLine("Welcome Bronze Customer!");
            base.PrintCustomer();
        }
    }

    class SilverCustomer : Customer
    {
        string level = "Silver";
        public override void AddCustomer()
        {
            base.AddCustomer();
        }

        public override void PrintCustomer()
        {
            Console.WriteLine("Welcome Silver Customer!");
            base.PrintCustomer();
        }
    }

    class GoldCustomer : Customer
    {
        string level = "Gold";
        public override void AddCustomer()
        {
            base.AddCustomer();
        }

        public override void PrintCustomer()
        {
            Console.WriteLine("Welcome Gold Customer!");
            base.PrintCustomer();
        }
    }

    class PlatinumCustomer : Customer
    {
        string level = "Platinum";
        public override void AddCustomer()
        {
            base.AddCustomer();
      
        }

        public override void PrintCustomer()
        {
            Console.WriteLine("Welcome Platinum Customer!");
            base.PrintCustomer();
        }

    }

    class ask 
    { 
        public void greet() 
        {
            Console.WriteLine("What's your level?");
            Console.WriteLine();
            Console.WriteLine("The options are :");
            string[] names=Enum.GetNames(typeof(options));
            int[] values=(int[])Enum.GetValues(typeof(options));
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]+" press ------ "+values[i]);
            }
        }
    
    }

    enum options
    {
        Bronze = 1,
        Silver,
        Gold,
        Platinum
    }


}
