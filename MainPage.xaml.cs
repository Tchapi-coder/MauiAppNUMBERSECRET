using Microsoft.Maui.Controls.Compatibility;

namespace MauiApp1NUMBERSECRET
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JouerPage());
        }

    }


    
}
