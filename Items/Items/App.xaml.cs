using System;
using Xamarin.Forms;
using Items.DataStores;
using Items.XamarinForms.Views;

namespace Items.XamarinForms
{
	public partial class App : Application
	{
		
        public static bool UseMockDataStore = false;
		
		public App ()
		{
			InitializeComponent();

			if (UseMockDataStore)
				DependencyService.Register<MockDataStore>();
			else
				DependencyService.Register<ItemDataStore>();

			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
