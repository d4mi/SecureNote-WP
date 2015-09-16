using SecureNote.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SecureNote
{
    public class App : Application
    {
        public App()
        {
            Bootstrap bootstrap = new Bootstrap();

            // The root page of your application
            MainPage = new MasterDetailPage
            {
                Master = new MenuView(),
                Detail = new NavigationPage(new MainView())
            };

           
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
