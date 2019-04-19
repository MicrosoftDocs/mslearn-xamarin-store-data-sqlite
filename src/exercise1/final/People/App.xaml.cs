using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace People
{
    public partial class App : Application
    {
        public static PersonRepository PersonRepo { get; private set; }

        public App(string dbPath)
        {
            InitializeComponent();

            PersonRepo = new PersonRepository(dbPath);

            MainPage = new People.MainPage();
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
