using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Class
    {
        private string ClassID { get; set; }
        private string ClassName { get; set; }
        private string Year { get; set; }

        public Class(string ClassID, string ClassName, string Year)
        {
            this.ClassID = ClassID;
            this.ClassName = ClassName;
            this.Year = Year;
        }
    }
}
