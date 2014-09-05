using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CashRebate:CashSuper
    {
        private double moneyRebate=1d;
        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = Convert.ToDouble(moneyRebate);
        }
    }
}
