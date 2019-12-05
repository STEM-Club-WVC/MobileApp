using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace WVCSTEMMobleApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArrowControlPage : ContentPage
    {
        public ArrowControlPage()
        {
            InitializeComponent();

            Log("Startup");

            new Button()
            {
                Text = "Skills",
                TextColor = Color.FromRgb(161, 161, 161),
                BorderColor = Color.FromRgb(161, 161, 161),
                BorderWidth = 1,
                HeightRequest = 40,
                //BorderRadius = 1,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };

            Log("Pre-Generate");
            GenerateControls();
            Log("Post-Generate");
        }

        public void GenerateControls()
        {
            var center = new Image { Source = "Icon.png", IsVisible = true };
            var arrowLeft = new Image { Source = "double_arrow.png", IsVisible = true };
            var arrowRight = new Image { Source = "double_arrow.png", IsVisible = true };
            arrowRight.RotationY = 180;
            var arrowTop = new Image { Source = "arrow.jpg", IsVisible = true };
            arrowTop.RotationY = 90;
            var arrowBottom = new Image { Source = "arrow.jpg", IsVisible = true };
            arrowBottom.RotationY = 270;
        }

        public static void Log(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}