using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Traing.UI.ConsoleApp
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Mobile { get; set; }

        public void AddEmployee() 
        {
            Console.WriteLine("Enter Id->");
            Id = Convert.ToInt32(Console.ReadLine());//console.read()--read as a string
            Console.Write("Enter name->");
            Name = Console.ReadLine();
            
            Console.WriteLine("Enter Department->");
            Department = Console.ReadLine();

            Console.WriteLine("Enter Mobile->");
            Mobile = Console.ReadLine();
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Id="+Id);
            Console.WriteLine("Name="+Name);
            Console.WriteLine("Department=" + Department);
         
        }
    }

    class FullTimeEmployee 
    { 
           
    }
    class PartTimeEmployee
    { 
        
    }

}

