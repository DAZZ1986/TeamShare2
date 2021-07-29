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
            label1.TextColor = Color.Cyan;
            label1.FontSize = 20;
            label1.FontAttributes = FontAttributes.Bold;

            layout.Children.Add(label1);

            Content = layout;
        }

    }
}