using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracker
{
    public class Receivable
    {
        private string BorrowerName;
        private DateTime ExpectedRepaymentDate;
        private bool IsInterestAccruing;
        private decimal RepaymentCollected;
    }
}
