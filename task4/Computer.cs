using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    abstract class Computer
    {
        private string ProcessorName { get; set; }
        private double Frequency { get; set; }
        private int AmountRAM { get; set; }

        protected Computer(string processorName, double frequency, int amountRAM)
        {
            ProcessorName = processorName;
            Frequency = frequency;
            AmountRAM = amountRAM;
        }

        public virtual string toString()
        {
            return $"Processor  name: {this.ProcessorName}, Processor frequency: {this.Frequency}, Amount of RAM: {this.AmountRAM}";
        }

        public virtual double CalculateQ()
        {
            return this.Frequency * 0.1 + this.AmountRAM;
        }
    }
}
