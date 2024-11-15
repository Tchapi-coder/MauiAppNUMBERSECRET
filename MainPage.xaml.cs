using Microsoft.Maui.Controls.Compatibility;

namespace MauiApp1NUMBERSECRET
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Initialisation de la NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }


    }
}
