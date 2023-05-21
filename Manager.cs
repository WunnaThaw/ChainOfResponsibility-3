using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    /// <summary>
    /// The 'ConcreteHandler' clas
    /// </summary>
    class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 100000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                sender.GetType().Name, e.Loan.Number);
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
            else
            {
                Console.WriteLine(
                "Request# {0} requires an executive meeting!",
                e.Loan.Number);
            }
        }
    }
}
