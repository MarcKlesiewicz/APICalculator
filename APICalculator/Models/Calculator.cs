using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculator.Models
{
    public class Calculator
    {
        public long Id { get; set; }
        public int number1 { get; set; }

        public int number2 { get; set; }

        public int result { get; set; }
    }
}
