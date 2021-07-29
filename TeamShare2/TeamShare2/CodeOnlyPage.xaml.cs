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
    public partial class CodeOnlyPage : ContentPage
    {
        public CodeOnlyPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            StackLayout layout = new StackLayout();

            Label label1 = new Label();
            label1.Text = "Urok 4";
            label1.TextColor = Color.Red;
            label1.FontSize = 20;
            label1.FontAttributes = FontAttributes.Bold;
            label1.HorizontalOptions = LayoutOptions.Center;
            //layout.Children.Add(label1);  // это не очень способ добавления элементов в StackLayout, лучше добавлять все элементы в конце.


            Entry input = new Entry();
            input.Placeholder = "Пароль";
            input.IsPassword = true;


            Entry input1 = new Entry()
            {
                IsEnabled = false,
                Text = "Some text"
            };


            // горизонтальный Layout
            StackLayout horizontalStack = new StackLayout();
            horizontalStack.Orientation = StackOrientation.Horizontal;

            Label sub = new Label()
            {
                Text = "Subscribe",
                FontSize = 25,
                FontAttributes = FontAttributes.Bold
            };

            CheckBox chekBox = new CheckBox()
            {
                IsChecked = true
            };




            horizontalStack.Children.Add(sub);
            horizontalStack.Children.Add(chekBox);

            layout.Children.Add(label1);
            layout.Children.Add(input);
            layout.Children.Add(input1);
            layout.Children.Add(horizontalStack);

            Content = layout;
        }

    }
}