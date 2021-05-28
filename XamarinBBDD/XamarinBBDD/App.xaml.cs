using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBBDD.Services;
using XamarinBBDD.Views;

namespace XamarinBBDD
{
    public partial class App : Application
    {


        public App()
        {
            InitializeComponent();
            ServiceIoC serviceIoC = new ServiceIoC();
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
