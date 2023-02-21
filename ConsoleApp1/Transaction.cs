using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Transaction
    {
        public double Value { get; set; }
        public DateTime Date { get; set; }
        public string Observation { get; set; }

        public Transaction(double value, DateTime date, string observation)
        {
            Value = value;
            Date = date;
            Observation = observation;
        }
    }
}
