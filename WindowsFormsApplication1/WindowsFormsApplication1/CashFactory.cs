using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CashFactory
    {
        //现金收费工厂
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
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
            return cs;
        }
    }
}
