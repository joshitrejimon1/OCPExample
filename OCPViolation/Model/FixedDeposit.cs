using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation.Model
{
    internal class FixedDeposit
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public double Principal { get; set; }
        public int Duration { get; set; }
        public FestivalTypes Festival { get; set; }

        public FixedDeposit(int accountNo, string name, double principal,int duration, FestivalTypes festival)
        {
            AccountNo = accountNo;
            Name = name;
            Principal = principal;
            Duration = duration;
            Festival = festival;
        }
       private double CalculateIntresetRate()
        {
            if (Festival == FestivalTypes.NEWYEAR)
                return 8;
            else if (Festival == FestivalTypes.DIWALI)
                return 8.5;
            else if (Festival == FestivalTypes.HOLI)
                return 7.5;
            return 6.5;
        }
        public double CalculateSimpleIntrest()
        {
            return (Principal * Duration * CalculateIntresetRate()) / 100;
        }
    }
}
