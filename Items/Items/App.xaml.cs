using System;
using Xamarin.Forms;
using Items.DataStores;
using Items.XamarinForms.Views;

namespace Items.XamarinForms
{
	public partial class App : Application
	{
		
        public static bool UseMockDataStore = false;

        public string AppId { get; set; }
        public string UserId { get; set; }


        public App ()
		{
			InitializeComponent();

            CheckDeviceRunStatus();
            EnsureUserIdentity();

            SetLocalDataStore();
            SetRemoteDataStore();
			

			MainPage = new MainPage();
		}

        /// <summary>
        /// Ensures there is a "first-run" DateTime value stored on device.
        /// </summary>
        /// <remarks>
        /// Useful for variety of onboarding or interval checking purposes.
        /// Good demonstration of secure, cross-platfrom app settings and persistence using ??.
        /// </remarks>
        private void CheckDeviceRunStatus()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void EnsureUserIdentity()
        {

        }

        private void SetLocalDataStore()
        {
            if (UseMockDataStore)
                DependencyService.Register<ItemMockDataStore>();
            else
                DependencyService.Register<ItemSqLiteDataStore>();
        }

        private void SetRemoteDataStore()
        {
            DependencyService.Register<ItemAzureDataStore>();
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
