using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_04
{
    class Scientist : Employee
    {
        public int PublishedPapers { get; set; }
        public int WorkDays { get; set; }
        public int SalaryRank { get; set; }

        public double CalculateSalary()
        {
            return WorkDays * SalaryRank;
        }
    }
    }
