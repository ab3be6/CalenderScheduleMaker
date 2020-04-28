using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderScheduleMaker
{
    public class CalenderSchedule
    {
        public string FileName { get; set; } = "Default";
        public Encoding TextEncoding { get; set; }
        public string ProductID { get; set; } = "GarbageList// HiratsukaCity";
        public string EventID { get; set; } = "@cal.id.ShotaAbe";
        public DateTime Startdate { get; set; }
        public DateTime Stopdate { get; set; }
        public bool AlarmEnable { get; set; }
        public AlarmSet.AlarmBefores AlarmBefore { get; set; }
        public List<EventData> EventsList { get; set; }

        public string GenerateCalData()
        {
            TimeSpan span = Stopdate - Startdate;
            string message = "";
            if (EventsList.Count == 0)
            {
                message = "Event data is NOT set yet.";
                return (message);
            }
            if (span.Days == 0)
            {
                message = "Start date or stop date is not set correcly.";
                return (message);
            }

            ExportData ExportEvents = new ExportData();

            int i = 0;
            int j = 0;
            for (i = 0; i < span.Days; i++)
            {
                DateTime thisDay = Startdate.AddDays(i);
                DateTime nextDay = thisDay.AddDays(1);
                int thisWeekDay = (int)thisDay.DayOfWeek; //Sun.:0, Sat.:6
                int thisWeekNum = 0;

                if (thisDay.Day <= 7)
                {
                    thisWeekNum = 1;
                }
                else if (thisDay.Day >= 8 && thisDay.Day <= 14)
                {
                    thisWeekNum = 2;
                }
                else if (thisDay.Day >= 15 && thisDay.Day <= 21)
                {
                    thisWeekNum = 3;
                }
                else if (thisDay.Day >= 22 && thisDay.Day <= 28)
                {
                    thisWeekNum = 4;
                }
                else if (thisDay.Day <= 29)
                {
                    thisWeekNum = 5;
                }

                for (j = 0; j < EventsList.Count; j++)
                {
                    bool thisMatched_WeekDay = false;
                    bool thisMatched_WeekNum = false;
                    bool WeeklyMode = EventsList[j].Weekly1st || EventsList[j].Weekly2nd || EventsList[j].Weekly3rd || EventsList[j].Weekly4th || EventsList[j].Weekly5th;

                    switch (thisWeekDay)
                    {
                        case 0: //Sunday
                            if (EventsList[j].Sunday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 1:
                            if (EventsList[j].Monday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 2:
                            if (EventsList[j].Tuesday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 3:
                            if (EventsList[j].Wednesday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 4:
                            if (EventsList[j].Thursday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 5:
                            if (EventsList[j].Friday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        case 6: //Saturday
                            if (EventsList[j].Saturday)
                            {
                                thisMatched_WeekDay = true;
                            }
                            break;
                        default:
                            thisMatched_WeekDay = false;
                            break;
                    }

                    switch (thisWeekNum)
                    {
                        case 1:
                            if (EventsList[j].Weekly1st)
                            {
                                thisMatched_WeekNum = true;
                            }
                            break;
                        case 2:
                            if (EventsList[j].Weekly2nd)
                            {
                                thisMatched_WeekNum = true;
                            }
                            break;
                        case 3:
                            if (EventsList[j].Weekly3rd)
                            {
                                thisMatched_WeekNum = true;
                            }
                            break;
                        case 4:
                            if (EventsList[j].Weekly4th)
                            {
                                thisMatched_WeekNum = true;
                            }
                            break;
                        case 5:
                            if (EventsList[j].Weekly5th)
                            {
                                thisMatched_WeekNum = true;
                            }
                            break;
                        default:
                            thisMatched_WeekNum = false;
                            break;
                    }

                    if (!WeeklyMode)
                    {
                        thisMatched_WeekNum = true;
                    }
                    if (thisMatched_WeekDay && thisMatched_WeekNum)
                    {
                        ExportEvents.eventName.Add(EventsList[j].EventName);
                        ExportEvents.eventDateStart.Add(thisDay.ToShortDateString());
                        ExportEvents.eventDateEnd.Add(nextDay.ToShortDateString());
                    }
                }
            }

            if (ExportEvents.eventName.Count == 0 || ExportEvents.eventDateStart.Count == 0 || ExportEvents.eventDateEnd.Count == 0)
            {
                message = "There is not valid event.";
                return (message);
            }
            message = GenarateICSFile(ExportEvents);
            return (message);
        }

        private string GenarateICSFile(ExportData exportData)
        {
            StreamWriter streamWriter = new StreamWriter(FileName, false, TextEncoding);
            AlarmSet alarmSet = new AlarmSet();

            // Write header
            streamWriter.WriteLine("BEGIN:VCALENDAR");
            streamWriter.WriteLine("PRODID:-//" + ProductID + "//EN");
            streamWriter.WriteLine("VERSION: 2.0");
            streamWriter.WriteLine("CALSCALE:GREGORIAN");
            streamWriter.WriteLine("METHOD:PUBLISH");
            streamWriter.WriteLine("X-WR-CALNAME:CallendarScheduleMaker");
            streamWriter.WriteLine("X-WR-TIMEZONE:Asia/Tokyo");

            int i;
            for (i = 0; i < exportData.eventName.Count; i++)
            {
                streamWriter.WriteLine("BEGIN:VEVENT"); // Event header

                streamWriter.WriteLine("UID:" + "ID" + i.ToString() + EventID);
                streamWriter.WriteLine("SUMMARY:" + exportData.eventName[i]);
                streamWriter.WriteLine("DTSTART;VALUE=DATE:" + exportData.eventDateStart[i].Replace("/", ""));
                streamWriter.WriteLine("DTEND;VALUE=DATE:" + exportData.eventDateEnd[i].Replace("/", ""));

                if (AlarmEnable) //Alarm setting
                {
                    streamWriter.WriteLine("BEGIN:VALARM"); //Alarm header
                    streamWriter.WriteLine("ACTION:DISPLAY");
                    streamWriter.WriteLine("DESCRIPTION:Reminder");
                    streamWriter.WriteLine("TRIGGER:" + alarmSet.Conv_AlarmBefores(AlarmBefore));
                    streamWriter.WriteLine("END:VALARM"); // Alarm footer
                }

                streamWriter.WriteLine("END:VEVENT");// Event footer
            }

            // Write footer
            streamWriter.Write("END:VCALENDAR");
            streamWriter.Close();

            return ("Generating ICS file is done.");
        }
    }
}
