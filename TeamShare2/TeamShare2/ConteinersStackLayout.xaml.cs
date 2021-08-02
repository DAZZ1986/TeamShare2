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
    public partial class ConteinersStackLayout : ContentPage
    {
        public ConteinersStackLayout()
        {
            InitializeComponent();
        }




        protected override void OnAppearing()
        {
            /*
            Теперь создадим эти же кнопки только через бэкэнд
            StackLayout stacklayout = new StackLayout();
            // Вариант 1 - создаем метки и боксвью - Это топорный вариант.
            Label label1 = new Label()
            {
                Text = "Основные цвета"
            };

            BoxView boxView1 = new BoxView() { Color = Color.Red };

            stacklayout.Children.Add(label1);
            stacklayout.Children.Add(boxView1);
            */

            /*
            // Вариант 2 - создадим инициализатор в stacklayout в колтором проинициализируем быстро коллекцию Children - более изящьный
            StackLayout stackLayout = new StackLayout()
            {
                Children = // при таком варианте у новых контролов у нас нету ссылки записанную в какуюто переменную на этот контрол и потом их проблематично
                           // будет их доставать, но тоже решаемо. А если обращаться к контролам этим в дальнейшем не нужно будет, то способ идеальный.
                {
                    new Label { Text = "Основные цвета!", Margin = new Thickness(0, 0, 0, 10) },
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new Label { Text = "Смесовые цвета!", Margin = new Thickness(0, 30, 0, 10) },
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple }
                },
                Spacing = 0
            };

            Content = stackLayout;
            */




            // создаем горизонтальный stacklayout из кода
            Content = new StackLayout
            { 
                Orientation = StackOrientation.Horizontal,
                Children =
                { 
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple }
                }

            };

        }









    }
}