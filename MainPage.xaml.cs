using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Grob_1.App;

namespace Grob_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {

            InitializeComponent();
        }
        // функция клика на кнопку отправить
        private async void ButtonClick(object sender, EventArgs e)
        {
            // проверка на заполнение полей
            if (string.IsNullOrEmpty(nameField.Text))
                errorText.Text = "Имя не указано";
            else if (string.IsNullOrEmpty(birthField.Text))
                errorText.Text = "Дата рождения не указана";
            else if (string.IsNullOrEmpty(deathField.Text))
                errorText.Text = "Дата смерти не указана";
            else
            {
                // вывод уведомления об успешном заходе
                errorText.Text = "";
                await DisplayAlert("", "Заявка отправлена", "Ок");
                // запись в те глобальные переменные
                GlobalName.MyVariable = nameField.Text;
                GlobalBirth.MyVariable = birthField.Text;
                GlobalDeath.MyVariable = deathField.Text;
                // переход на вторую страницу
                await Navigation.PushAsync(new secpage());
            }

        }
    }
}
// то же самое на с++
// Глобальные переменные
//std::string GlobalName = "";
//std::string GlobalBirth = "";
//std::string GlobalDeath = "";

// Функция для проверки заполнения полей
//bool IsFieldEmpty(const std::string& field)
//{
//return field.empty();
//}

// Функция для вывода уведомления
//void DisplayAlert(const std::string& message)
//{
//std::cout << "Alert: " << message << std::endl;
//}

// Функция для обработки нажатия кнопки
//void ButtonClick(const std::string& name, const std::string& birth, const std::string& death)
//{
// Проверка на заполнение полей
//if (IsFieldEmpty(name))
//DisplayAlert("Имя не указано");
//    else if (IsFieldEmpty(birth))
//DisplayAlert("Дата рождения не указана");
//   else if (IsFieldEmpty(death))
//DisplayAlert("Дата смерти не указана");
//    else
//{
// Вывод уведомления об успешном заходе
//DisplayAlert("Заявка отправлена");
// Запись в глобальные переменные
//GlobalName = name;
//GlobalBirth = birth;
//GlobalDeath = death;
// Переход на вторую страницу



//int main()
//{
//ButtonClick("Иванов Иван Иванович", "01.01.1990", "01.01.2023");

//return 0;
//}
