using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinBBDD.Views;

namespace XamarinBBDD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainDepartamentos();
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
