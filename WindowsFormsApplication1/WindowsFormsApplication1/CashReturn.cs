using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CashReturn:CashSuper
    {
        private double moneyCondition;
        private double moneyReturn;
        public CashReturn(string moneyConditon,string moneyReturn)
        {
            this.moneyCondition = double.Parse(moneyConditon);
            this.moneyReturn = double.Parse(moneyReturn);
        }
        public override double acceptCash(double money)
        {
            double result = money;
            if(money>moneyCondition)
            {
                result = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return result;
        }
    }
}
