using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderScheduleMaker
{
    public class AlarmSet
    {
        public enum AlarmBefores
        {
            _5Min,
            _15Min,
            _30Min,
            _1Hour,
            _1Day,
            _2Day,
            _1Week
        }

        public string Conv_AlarmBefores(AlarmBefores alarmBefores)
        {
            switch (alarmBefores)
            {
                case AlarmBefores._15Min:
                    return "-PT15M";
                case AlarmBefores._1Day:
                    return "-P1D";
                case AlarmBefores._1Hour:
                    return "-PT1H";
                case AlarmBefores._1Week:
                    return "-P1W";
                case AlarmBefores._2Day:
                    return "-P2D";
                case AlarmBefores._30Min:
                    return "-PT30M";
                case AlarmBefores._5Min:
                    return "-PT5M";
                default:
                    return null;
            }
        }
    }
}
