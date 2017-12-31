using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyTokyoTrip
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DayPage : ContentPage
    {
        public DayPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext is ObservableCollection<ActivityModel> collection)
            {
                for (int i = 0; i < collection.Count(); i++)
                {
                    container.Children.Add(new ActivityView
                    {
                        BindingContext = collection[i],
                        Postion = i % 2 == 0 ? ActivityView.ContentPosition.Left : ActivityView.ContentPosition.Right
                    });
                };
            }
        }
    }
}