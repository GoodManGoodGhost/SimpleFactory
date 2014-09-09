using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CashContext
    {
        CashSuper cs = null;
        public CashContext(CashSuper cs)
        {
            this.cs = cs;
        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
