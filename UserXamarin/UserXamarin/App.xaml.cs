using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UserXamarin
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();
            DependencyService.Register<services.IUserService, services.UserServices>();
            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

