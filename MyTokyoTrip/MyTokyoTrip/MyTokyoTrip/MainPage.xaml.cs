using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTokyoTrip
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        public ActivityModels activityModels;

        public MainPage()
        {
            InitializeComponent();
            activityModels = new ActivityModels();

            CurrentPage = Children.FirstOrDefault();
            Title = "1월 9일";
            CurrentPageChanged += CarouselPage_CurrentPageChanged;

            Jan9thPage.BindingContext = activityModels.Jan9th;
            Jan10thPage.BindingContext = activityModels.Jan10th;
            Jan11thPage.BindingContext = activityModels.Jan11th;
            Jan12thPage.BindingContext = activityModels.Jan12th;
        }

        private void CarouselPage_CurrentPageChanged(object sender, EventArgs e)
        {
            var index = Children.IndexOf(CurrentPage);
            var page = (Application.Current.MainPage as NavigationPage);

            switch (index)
            {
                case 0:
                    Title = "1월 9일";
                    break;
                case 1:
                    Title = "1월 10일";
                    break;
                case 2:
                    Title = "1월 11일";
                    break;
                case 3:
                    Title = "1월 12일";
                    break;
            }
        }
    }
}
