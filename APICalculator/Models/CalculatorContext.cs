using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICalculator.Models
{
    public class CalculatorContext :DbContext
    {
        public CalculatorContext(DbContextOptions<CalculatorContext> options)
            : base(options)
        {

        }

        public DbSet<Calculator> Calculators { get; set; }
    }
}
