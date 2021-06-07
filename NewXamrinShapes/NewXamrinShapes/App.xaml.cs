using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NewXamrinShapes.View;

namespace NewXamrinShapes
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Shapes_Experimental", "Brush_Experimental" });
            InitializeComponent();
            MainPage = new NavigationPage(new Menu1());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
