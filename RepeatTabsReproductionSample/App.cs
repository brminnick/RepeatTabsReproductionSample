using Xamarin.Forms;

namespace RepeatTabsReproductionSample
{
    public class App : Application
    {
        public App()
        {
            var samplePage1 = new ContentPage { Title = "1" };
            var samplePage2 = new ContentPage { Title = "2" };
            var samplePage3 = new ContentPage { Title = "3" };

            CustomTabbedPage.Instance.Children.Add(samplePage1);
            CustomTabbedPage.Instance.Children.Add(samplePage2);
            CustomTabbedPage.Instance.Children.Add(samplePage3);

            MainPage = CustomTabbedPage.Instance;
        }

        protected override void OnResume()
        {
            base.OnResume();

            Current.MainPage.DisplayAlert("OnResume Triggered", "", "OK");
        }
    }

    class CustomTabbedPage : TabbedPage
    {
        static CustomTabbedPage _instance;

        public static CustomTabbedPage Instance => _instance ?? (_instance = new CustomTabbedPage());
    }
}

