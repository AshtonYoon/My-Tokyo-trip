using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTokyoTrip
{
    public class ActivityModels
    {
        public ObservableCollection<ActivityModel> Jan9th = new ObservableCollection<ActivityModel>();
        public ObservableCollection<ActivityModel> Jan10th = new ObservableCollection<ActivityModel>();
        public ObservableCollection<ActivityModel> Jan11th = new ObservableCollection<ActivityModel>();
        public ObservableCollection<ActivityModel> Jan12th = new ObservableCollection<ActivityModel>();

        public ActivityModels()
        {
            DateTime startTime;
            DateTime endTime;

            DateTime.TryParse("09/01/2018 00:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 05:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "취침",
                ActivityDescription = "인천국제공항 캡슐 호텔"
            });
        }
    }
}
