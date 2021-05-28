using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBBDD.Services;
using XamarinBBDD.Views;

namespace XamarinBBDD
{
    public partial class App : Application
    {
        private static ServiceIoC _ServiceLocator;
        public static ServiceIoC ServiceLocator
        {
            get
            {
                return _ServiceLocator = _ServiceLocator
                    ?? new ServiceIoC();
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new MainPersonajes();
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
