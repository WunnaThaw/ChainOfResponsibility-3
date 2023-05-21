using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1
{
    // Loan event argument holds Loan info
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }
}
