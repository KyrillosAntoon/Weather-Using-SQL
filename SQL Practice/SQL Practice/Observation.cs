using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Practice
{
    /// <summary>
    /// This class acts contains all the fields that will be used in the XML file
    /// </summary>
    class Observation
    {
        public string city { get; set; }
        public float temperature { get; set; }
        public float pressure { get; set;}
        public int Coverage { get; set; }
    }
}
