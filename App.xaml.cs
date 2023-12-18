using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grob_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // навигация всех страниц
            MainPage = new NavigationPage(new MainPage());
        }
        // создание глобальной переменной имени
        public static class GlobalName
        {
            public static string MyVariable { get; set; }
        }
        // создание глобальной переменной даты рождения
        public static class GlobalBirth
        {
            public static string MyVariable { get; set; }
        }
        // создание глобальной переменной даты смерти
        public static class GlobalDeath
        {
            public static string MyVariable { get; set; }
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
