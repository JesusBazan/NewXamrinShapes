using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewXamrinShapes.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu1 : ContentPage
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var rectangulo = new Rectangulo();
            Navigation.PushModalAsync(rectangulo);
            NavigationPage.SetHasNavigationBar(rectangulo, true);
            NavigationPage.SetHasBackButton(rectangulo, true);
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //Elipse
            Navigation.PushModalAsync(new Elipse());
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Linea());
        }
    }
}