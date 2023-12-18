using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grob_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class shop : ContentPage
    {
        public shop()
        {
            // вывод страницы на экран
            InitializeComponent();
        }
        // переход на страницу с гробами при нажатии на фрейм
        private async void FrameTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new grob_item());
        }
    }
}