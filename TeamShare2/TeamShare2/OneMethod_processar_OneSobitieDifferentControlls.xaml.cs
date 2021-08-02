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
    public partial class OneMethod_processar_OneSobitieDifferentControlls : ContentPage
    {

        // Как один метод может обрабатывать одно событие разных контролов.
        // Естественно для каждого конкретного события должен быть отдельный обработчик, но этот обработчик может обрабатывать события разных контролов. Которые
        // посылают и являются инсточником этого события.
        public OneMethod_processar_OneSobitieDifferentControlls()
        {
            InitializeComponent();
        }


        protected override void OnAppearing()
        {
            Button btn = null;

            for (int i = 0; i < 10; i++)
            {
                btn = new Button();
                btn.Text = $"Кнопка {i}";
                btn.BackgroundColor = Color.FromRgb(i * 9, i * 27, i * 19);

                btn.Clicked += Btn_Clicked;

                stacklayout1.Children.Add(btn);
            }
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("", $"{(sender as Button).Text}", "Ok");
        }




    }
}