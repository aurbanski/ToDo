using Xamarin.Forms;
using System;
using ToDo.Data;

namespace ToDo
{
    public partial class App : Application
    {
        private static ToDoDatabase database;

        public static ToDoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ToDoDatabase();
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CreatePage());
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
