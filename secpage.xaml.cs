using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Grob_1.App;

namespace Grob_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class secpage : ContentPage
    {
        public secpage()
        {
            // вывод страницы на экран
            InitializeComponent();
            // вывод записей из глобальных переменных
            namestring.Text = GlobalName.MyVariable;
            birthstring.Text = GlobalBirth.MyVariable;
            deathstring.Text = GlobalDeath.MyVariable;
        }
         // переход на страницу морга
        private async void ButtonMorg(object sender, EventArgs e)
        {
            {
                await Navigation.PushAsync(new morg());
            }
        }
        // переход на страницу кладбища
        private async void ButtonKlad(object sender, EventArgs e)
        {
            {
                await Navigation.PushAsync(new klad());
            }
        }
        // переход на страницу магазина
        private async void ButtonShop(object sender, EventArgs e)
        {
            {
                await Navigation.PushAsync(new shop());
            }
        }
    }
}