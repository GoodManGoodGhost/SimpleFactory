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
        public CashContext(string acceptStrategy)
        {
            switch (acceptStrategy)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;
                case "满300返100":
                    cs = new CashReturn("300", "100");
                    break;
                case "打八折":
                    cs = new CashRebate("8");
                    break;
                case "打七折":
                    cs = new CashRebate("7");
                    break;
                case "打五折":
                    cs = new CashRebate("5");
                    break;
            }
        }
        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }
}
