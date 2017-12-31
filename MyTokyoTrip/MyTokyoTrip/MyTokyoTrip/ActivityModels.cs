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

            DateTime.TryParse("09/01/2018 05:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 07:25:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "기상 및 출국 준비",
                ActivityDescription = "USIM칩 수령, 티웨이항공"
            });

            DateTime.TryParse("09/01/2018 07:25:00.00", out startTime);
            DateTime.TryParse("09/01/2018 09:55:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "출국",
                ActivityDescription = ""
            });

            DateTime.TryParse("09/01/2018 09:55:00.00", out startTime);
            DateTime.TryParse("09/01/2018 12:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "시내 도착 및 호텔 체크인",
                ActivityDescription = "나리타 익스프레스 제 1터미널\n신주쿠 역\n메트로 패스 수령"
            });

            DateTime.TryParse("09/01/2018 12:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 13:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "점심식사",
                ActivityDescription = ""
            });

            DateTime.TryParse("09/01/2018 13:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 18:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "신주쿠 도시 구경 및 쇼핑",
                ActivityDescription = ""
            });

            DateTime.TryParse("09/01/2018 18:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 19:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "도쿄 무역타워",
                ActivityDescription = ""
            });

            DateTime.TryParse("09/01/2018 19:00:00.00", out startTime);
            DateTime.TryParse("09/01/2018 20:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "저녁",
                ActivityDescription = "편의점 털이 ㅎㅎ"
            });

            DateTime.TryParse("09/01/2018 20:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 06:00:00.00", out endTime);
            Jan9th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "휴식",
                ActivityDescription = "첫 날은 여유롭게"
            });
        }
    }
}
