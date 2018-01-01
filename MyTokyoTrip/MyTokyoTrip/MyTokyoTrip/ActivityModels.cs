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
            DateTime.TryParse("09/01/2018 00:00:00.00", out DateTime startTime);
            DateTime.TryParse("09/01/2018 05:00:00.00", out DateTime endTime);
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
                ActivityName = "휴힉 및 취침",
                ActivityDescription = "첫 날은 여유롭게"
            });

            DateTime.TryParse("10/01/2018 06:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 07:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "기상 및 준비",
                ActivityDescription = ""
            });

            DateTime.TryParse("10/01/2018 07:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 08:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "디즈니랜드 이동",
                ActivityDescription = ""
            });

            DateTime.TryParse("10/01/2018 08:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 20:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "디즈니랜드!!",
                ActivityDescription = "여기에 가고 싶은 어트랙션 적어두기"
            });

            DateTime.TryParse("10/01/2018 20:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 21:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "신주쿠 도착",
                ActivityDescription = ""
            });

            DateTime.TryParse("10/01/2018 21:00:00.00", out startTime);
            DateTime.TryParse("10/01/2018 23:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "술집",
                ActivityDescription = "가고싶은 술집 찾기"
            });

            DateTime.TryParse("10/01/2018 23:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 09:00:00.00", out endTime);
            Jan10th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "휴식 및 취침",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 09:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 10:00:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "기상 및 준비",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 10:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 11:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "브런치 :)",
                ActivityDescription = "Mr.Parmer"
            });

            DateTime.TryParse("11/01/2018 10:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 11:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "브런치 :)",
                ActivityDescription = "Mr.Parmer"
            });

            DateTime.TryParse("11/01/2018 11:30:00.00", out startTime);
            DateTime.TryParse("11/01/2018 14:00:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "신주쿠 근처 놀 곳 구경",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 14:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 15:00:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "아사쿠사 이동",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 15:00:00.00", out startTime);
            DateTime.TryParse("11/01/2018 17:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "아사쿠사 구경",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 17:30:00.00", out startTime);
            DateTime.TryParse("11/01/2018 18:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "아사쿠사 호텔 식사",
                ActivityDescription = "아사쿠사뷰 호텔 무사시 스카이 뷔페"
            });

            DateTime.TryParse("11/01/2018 18:30:00.00", out startTime);
            DateTime.TryParse("11/01/2018 20:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "아사쿠사 온천",
                ActivityDescription = "Jakotsuyu"
            });

            DateTime.TryParse("11/01/2018 20:30:00.00", out startTime);
            DateTime.TryParse("11/01/2018 22:30:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "신주쿠 이동 및 야시장 먹거리 쇼핑",
                ActivityDescription = ""
            });

            DateTime.TryParse("11/01/2018 20:30:00.00", out startTime);
            DateTime.TryParse("12/01/2018 09:00:00.00", out endTime);
            Jan11th.Add(new ActivityModel
            {
                StartTime = startTime,
                EndTime = endTime,
                ActivityName = "휴식 및 취침",
                ActivityDescription = ""
            });
        }
    }
}
