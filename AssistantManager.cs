using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    /// <summary>
    /// The 'ConcreteHandler' class
    /// </summary>
    class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 45000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, e.Loan.Number);
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
        }
    }
}
