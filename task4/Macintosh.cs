using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Macintosh : Computer
    {
        private double AmountHdd { get; set; }

        public Macintosh(string processorName, double frequency, int amountRAM, double amountHdd) :
            base(processorName, frequency, amountRAM)
        {
            AmountHdd = amountHdd;
        }

        public override double CalculateQ()
        {
            return Math.Round((base.CalculateQ() + this.AmountHdd * 0.5), 0);
        }

        public override string toString()
        {
            return base.toString() + $" Macintosh amount of Hdd: {this.AmountHdd}";
        }
    }
}
