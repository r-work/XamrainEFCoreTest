using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamrainEFCoreTest.Services;
using XamrainEFCoreTest.Views;

namespace XamrainEFCoreTest
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Repro.Test();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
