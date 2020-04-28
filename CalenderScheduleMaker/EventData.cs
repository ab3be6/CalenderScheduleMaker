using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderScheduleMaker
{
    public class EventData
    {
        public EventData()
        { }

        public string EventName { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Weekly1st { get; set; }
        public bool Weekly2nd { get; set; }
        public bool Weekly3rd { get; set; }
        public bool Weekly4th { get; set; }
        public bool Weekly5th { get; set; }
    }
}
