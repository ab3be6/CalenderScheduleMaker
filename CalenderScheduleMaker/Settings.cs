using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderScheduleMaker
{
    public class UserSettings
    {
        public string FileName { get; set; }
        public string TextEncoding { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Stopdate { get; set; }
        public bool AlarmEnable { get; set; }
        public AlarmSet.AlarmBefores AlarmBefore { get; set; }
        public List<EventData> EventsList { get; set; }
        public UserSettings()
        {
            this.EventsList = new List<EventData>();
        }
    }
}
