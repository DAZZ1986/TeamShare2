using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamShare2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            button1.Clicked += Button1_Clicked;

        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Byte++", "Вы подписаны", "OK");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}