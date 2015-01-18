using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.Models
{
    public enum DayOfWeek{
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    public class ScheduleList
    {
        public int ID { get; set; }
        public int SeriesID { get; set; }
        public int ChannelID { get; set; }
        public DayOfWeek OnDay { get; set; }
        public DateTime OnHour { get; set; }
        public int Rating { get; set; }

        public virtual TVSeries TVSeries { get; set; }
        public virtual TVChannel TVChannel { get; set; }
    }
}
