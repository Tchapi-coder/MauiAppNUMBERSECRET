namespace MauiApp1NUMBERSECRET;

public partial class  JouerPage : ContentPage
{	private readonly Random random = new();
    readonly int nombreSecret;
   readonly int MaxNonIncluse;
    private readonly int tentatives;

    public JouerPage()
	{
        MinIncluse = 0;
        MaxNonIncluse = 100;
		InitializeComponent();
		nombreSecret = random.Next(MinIncluse, MaxNonIncluse);
		NombreLabel.Text = $"Le nombre secret est entre {MinIncluse} et {MaxNonIncluse}";
	}

    public int MinIncluse { get; private set; }
	 
	private Task<string> NavigationPopAsync()
	{
		throw new NotImplementedException();
	}
    private void DisplayAlert(string v1, string v2)
    {
        throw new NotImplementedException();
    }
    
    public async void DevinerBtn_Clicked(int nombre)
		
	{
        tentatives++;
		{
            if (nombre == nombreSecret)
            {
                await DisplayAlert("Secret Number", $"Bingo, you guessed the right number" + $"{nombre} dans {tentatives} tentatives", "Ok");
                await NavigationPopAsync();

            }
            else
            {
                if (nombre > nombreSecret)
                {
                    DisplayAlert("Secret Number", $"The number is less than {nombre}.keep trying, you will get it");
                    NombreEntry.Text = "";


                }
                else
                {
                    DisplayAlert("Secret Number", $"The number is greater than {nombre}. keep trying you will get it");
                    NombreEntry.Text = "";

                }
            }
        }

	}

     
}

