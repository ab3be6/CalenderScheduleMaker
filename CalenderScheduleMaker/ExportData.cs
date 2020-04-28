using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderScheduleMaker
{
    public class ExportData
    {
        public List<string> eventName { get; set; }
        public List<string> eventDateStart { get; set; }
        public List<string> eventDateEnd { get; set; }
        public bool alarmEnable { get; set; }
        public AlarmSet.AlarmBefores alarmBefore { get; set; }
        public ExportData()
        {
            eventName = new List<string>();
            eventDateStart = new List<string>();
            eventDateEnd = new List<string>();
        }
    }
}
