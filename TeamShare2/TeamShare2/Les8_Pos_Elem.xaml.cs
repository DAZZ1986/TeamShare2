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
    public partial class Les8_Pos_Elem : ContentPage
    {
        public Les8_Pos_Elem()
        {
            InitializeComponent();
        }

        // делаем позиционирование через C# код.
        protected override void OnAppearing()
        {

            /*
            StackLayout stackLayout1 = new StackLayout()
            {
                Margin = new Thickness(15), // тут сделал марджин чтобы он отодвинулся на 15 ед. от всех краев экрана.
                Orientation = StackOrientation.Horizontal,
                Children =  // далее присваиваем коллекции children, коллекцию label'ов. 
                { 
                    new Label { Text = "On left", BackgroundColor=Color.Gray, VerticalOptions=LayoutOptions.Start },
                    new Label { Text = "On middle", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Center },
                    new Label { Text = "On right", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.End },
                    new Label { Text = "On Fill", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Fill }
                }
            };

            Content = stackLayout1;
            */
        }




    }
}