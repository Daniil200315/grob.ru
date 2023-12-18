using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Grob_1.App;

namespace Grob_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class korzina : ContentPage
    {

        public korzina()
        {
            InitializeComponent(); 
        }
        // функция счета кнопки
        private int functionCallCountDub = 0;

        public void CreateNewElement()
        {

            functionCallCountDub++;

            // создание новой записи в корзине о добавлении
            StackLayout newstackLayout = new StackLayout();

            Label label1 = new Label
            {
                Text = "• Гроб дуб",
                TextColor = Color.Black,
                FontSize = 20
            };

            Label label2 = new Label
            {
                Text = "  Цена: 30000 ₽",
                TextColor = Color.Black,
                FontSize = 20
            };
            // подсчет итоговой цены с учетом добавленных товаров
            int a = int.Parse(price.Text);
            int b = a + 30000;
            string b_price = b.ToString();
            price.Text = b_price;

            // то же самое только на C++:
            //int main()
            //{

            //
            //std::string price = "10000";

            // Преобразование строки в целое число
            // int a = std::stoi(price);

            // Выполнение операции
            //int b = a + 30000;

            // Преобразование числа в строку
            //std::string b_price = std::to_string(b);

            // Вывод результата
            //std::cout << "Исходное значение: " << price << std::endl;
            //std::cout << "После операции: " << b_price << std::endl;

            // return 0;
            // }


            newstackLayout.Children.Add(label1);
            newstackLayout.Children.Add(label2);
            // Добавление нового StackLayout к родительскому StackLayout
            mainStackLayout.Children.Add(newstackLayout);
        }

        // функция счета кнопки

        private int functionCallCountLipa = 0;
        
        public void CreateNewElementLipa()
        {
            functionCallCountLipa++;

            // создание новой записи в корзине о добавлении
            StackLayout newstackLayout = new StackLayout();

            Label label1 = new Label
            {
                Text = "• Гроб липа",
                TextColor = Color.Black,
                FontSize = 20
            };

            Label label2 = new Label
            {
                Text = "  Цена: 20000 ₽",
                TextColor = Color.Black,
                FontSize = 20
            };
            // подсчет итоговой цены с учетом добавленных товаров
            int aa = int.Parse(price.Text);
            int b = aa + 20000;
            string b_price = b.ToString();
            price.Text = b_price;

            newstackLayout.Children.Add(label1);
            newstackLayout.Children.Add(label2);
            // Добавление нового StackLayout к родительскому StackLayout
            mainStackLayout.Children.Add(newstackLayout);
        }

        private async void ButtonClickOplata(object sender, EventArgs e)
        {
            // переменные для записи и вывода в формате JSON
            string pricefil = price.Text;
            string fio = GlobalName.MyVariable;
            string birth = GlobalBirth.MyVariable;
            string death = GlobalDeath.MyVariable;
            string dub = "Гроб дуб" + functionCallCountDub.ToString();
            string lipa = "Гроб липа" + functionCallCountLipa.ToString();

            
            // Создаем объект для сериализации в JSON
            var data = new
            {
                FIO = fio,
                Birth = birth,
                Death = death,
                Dub = dub,
                Lipa = lipa,
                Price = pricefil
            };

            //то же самое на с++
            //int main()
            //{

            //std::string pricefil = "Ваша_цена";  
            //std::string fio = "Ваше_ФИО";      
            //std::string birth = "Дата_рождения"; 
            //std::string death = "Дата_смерти";    
            //int functionCallCountDub = 42;  
            //int functionCallCountLipa = 23; 

            // Создаем JSON-объект
            //json data = {
            // { "FIO", fio},
            //// { "Birth", birth},
            //{ "Death", death},
            // { "Dub", "Гроб дуб" + std::to_string(functionCallCountDub)},
            // { "Lipa", "Гроб липа" + std::to_string(functionCallCountLipa)},
            // { "Price", pricefil}
            // };

            // Выводим JSON в консоль
            //std::cout << data.dump(4) << std::endl;

            //return 0;
            // }








            // поиск нужного пространства для вывода JSON
            string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(appDataFolder, "mydb.json");

            string jsonData = JsonConvert.SerializeObject(data);

            File.WriteAllText(filePath, jsonData);
            // вывод пути в консоль 
            System.Diagnostics.Debug.WriteLine(filePath, jsonData);

            // вывод сообщения о покупке

            await DisplayAlert("", "Спасибо за покупку!", "Ок");
        }
            
    }
}