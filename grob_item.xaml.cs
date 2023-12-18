using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Grob_1.korzina;

namespace Grob_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class grob_item : ContentPage
    {
        public grob_item()
        {
            InitializeComponent();
        }
        // создание страницы корзины
        korzina secondPage = new korzina();

        // функция клика на кнопку для добавления первого товара
        private async void ButtonClickDub(object sender, EventArgs e)
        {           
            // Вызов метода для создания элемента на второй странице
            secondPage.CreateNewElement();        
        }
        // функция клика на кнопку для добавления второго товара
        private async void ButtonClickLipa(object sender, EventArgs e)
        {
            // Вызов метода для создания элемента на второй странице
            secondPage.CreateNewElementLipa();           
        }
        // функция клика на кнопку для перехода на другую страницу
        private async void ButtonClickKorz(object sender, EventArgs e)
        {
            Navigation.PushAsync(secondPage);
        }

    }
}