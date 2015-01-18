using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace web.Models
{
    public class TVChannel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ScheduleList> Schedule { get; set; }
    }
}
