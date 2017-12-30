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
    public partial class ActivityView : Grid
    {
        public enum ContentPosition
        {
            Left,
            Right
        };

        public static readonly BindableProperty PositionProperty = BindableProperty.Create("Position", typeof(ContentPosition), typeof(ActivityView), defaultValue: ContentPosition.Left,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                var view = bindableObject as ActivityView;
                var container = view.container;

                switch ((ContentPosition)newValue)
                {
                    case ContentPosition.Left:
                        SetColumn(container, 0);

                        container.HorizontalOptions = LayoutOptions.End;
                        foreach (Label child in container.Children)
                        {
                            child.HorizontalTextAlignment = TextAlignment.End;
                            child.HorizontalOptions = LayoutOptions.Fill;
                        }
                        break;
                    case ContentPosition.Right:
                        SetColumn(container, 1);
                        
                        container.HorizontalOptions = LayoutOptions.Start;
                        foreach (Label child in container.Children)
                        {
                            child.HorizontalTextAlignment = TextAlignment.Start;
                            child.HorizontalOptions = LayoutOptions.Start;
                        }
                        break;
                }
            });

        public ContentPosition Postion
        {
            get => (ContentPosition)GetValue(PositionProperty);
            set => SetValue(PositionProperty, value);
        }

        public ActivityView()
        {
            InitializeComponent();
        }
    }
}