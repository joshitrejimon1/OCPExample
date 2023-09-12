using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSoluction.Model
{
    internal class FixedDeposit
    {
        public int AccountNo { get; set; }
        public string Name { get; set; }
        public double Principal { get; set; }
        public int Duration { get; set; }
        public IFestivalInterface Festival { get; set; }

        public FixedDeposit(int accountNo, string name, double principal, int duration, IFestivalInterface festival)
        {
            AccountNo = accountNo;
            Name = name;
            Principal = principal;
            Duration = duration;
            Festival = festival;
        }

        public double CalculateSimpleIntrest()
        {
            return (Principal * Duration * Festival.GetIntrest()) / 100;
        }
    }
}
