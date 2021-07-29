using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeamShare2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CodeOnlyPage();
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
