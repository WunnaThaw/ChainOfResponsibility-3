using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    class Program
    {
        static void Main(string[] args)
        {
             // Setup Chain of Responsibility
            Approver myo = new Clerk();
            Approver khin = new AssistantManager();
            Approver chris = new Manager();

            myo.Successor = khin;
            khin.Successor = chris;
 
            // Generate and process loan requests
            var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
            myo.ProcessRequest(loan);
 
            loan = new Loan { Number = 2035, Amount = 42000.10, Purpose = "Bike Loan" };
            myo.ProcessRequest(loan);
 
            loan = new Loan { Number = 2036, Amount = 156200.00, Purpose = "House Loan" };
            myo.ProcessRequest(loan);
 
            // Wait for user
            Console.ReadKey();
        }
    }
}
