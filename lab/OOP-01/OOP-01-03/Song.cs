using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01_03
{
    internal class Song
    {
    
        public Song( string typelist , string name, string time)
        {
            Typelist = typelist;
            Name = name;
            Time = time;
        }

        public string Typelist { get; set; }
        public string Name { get; set; }
        public string Time { get; set ; }
    }
}
