namespace MauiApp1NUMBERSECRET;

public partial class  JouerPage : ContentPage
{
    public JouerPage()
    {
        int nombreSecret = 7;
        int MinIncluse = 1;
        int MaxNonIncluse = 20;
        Random random = new Random();
        InitializeComponent();
        nombreSecret = random.Next(MinIncluse, MaxNonIncluse);
        NombreLabel.Text = $"The secret number is between {MinIncluse} et {MaxNonIncluse}";
    }
    private async void DevinerBtn_Clicked(object sender, EventArgs e)
    {
        int tentatives = 0;
        int nombreSecret = 7;
        int nombre;
        bool estNombre = int.TryParse(NombreEntry.Text, out nombre);
        tentatives++;
        if (estNombre)
        {
            if (nombre == nombreSecret)
            {
                await DisplayAlert("Secret Number", $"Amazing, you have guessed the secret number {nombre} in {tentatives} tentatives", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                if (nombre > nombreSecret)
                {
                    await DisplayAlert("Secret Number", $"The number is less than{nombre},keep trying", "OK");
                    NombreEntry.Text = "";
                }
                else
                {
                    await DisplayAlert("Secret Number", $"The number is greater than{nombre},keep trying", "OK");
                    NombreEntry.Text = "";
                }
            }
        }
    }

}