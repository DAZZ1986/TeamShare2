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
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }


        private void ButtonHello_Click(object sender, EventArgs e) 
        {
            Label1.Text = Entry1.Text;
        }

        private void ButtonHello_Click2(object send, EventArgs e)
        {
            Label2.Text = Entry2.Text;
        }

    }
}