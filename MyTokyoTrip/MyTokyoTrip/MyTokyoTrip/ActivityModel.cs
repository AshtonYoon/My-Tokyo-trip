using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTokyoTrip
{
    public class ActivityModel
    {
        private DateTime startTime;
        private DateTime endTime;

        private string activityName;
        private string activityDescription;

        public DateTime StartTime { get => startTime; set => startTime = value; }
        public DateTime EndTime { get => endTime; set => endTime = value; }
        public string ActivityName { get => activityName; set => activityName = value; }
        public string ActivityDescription { get => $"{activityDescription}\n\n"; set => activityDescription = value; }

        public string ActivityTime => $"{string.Format("{0:HH:mm}", startTime)} - {string.Format("{0:HH:mm}", endTime)}";
    }
}
