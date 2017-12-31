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

            Jan9thPage.BindingContext = activityModels.Jan9th;
            Jan9thPage.Title = "1월 9일";
        }
    }
}
