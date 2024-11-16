namespace MauiApp1NUMBERSECRET;

public partial class  JouerPage : ContentPage
{	private readonly Random random = new();
    readonly int nombreSecret;
    
    readonly int MaxNonIncluse;
     int tentatives;
    
    public JouerPage()
        
	{
        MinIncluse = 0;
        MaxNonIncluse = 15;
		InitializeComponent();
		nombreSecret = random.Next(MinIncluse, MaxNonIncluse);
		NombreLabel.Text = $"Le nombre secret est entre {MinIncluse} et {MaxNonIncluse}";
	}
    private void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
    {
        {
            stepperValueLabel.Text = $"Valeur actuelle : {e.NewValue}";
        }
    }
    public int MinIncluse { get; private set; }
 
    private void DisplayAlert(string v1, string v2)
    {
        throw new NotImplementedException();
    }
    
    private async void DevinerBtn_Clicked(object sender , EventArgs e)
		
	{
        tentatives ++;
		{
            int nombre = int.Parse(NombreEntry.Text);
            if (nombre > nombreSecret)
            {
                await DisplayAlert("secret Number", "Secret Number", $"The number is great than {nombre}.try again, you will get it");
            }
            else
            {
                if (nombre < nombreSecret)
                {
                    await DisplayAlert("secret Number", "Secret Number", $"The number is less than {nombre}.try again, you will get it");
                }
                else
                {
                   DisplayAlert("Amazing!","This is the right number! ");
                   

                }
            }   NombreEntry.Text = "";
        }

	}

     
}

class stepperValueLabel
{
    internal static string Text;
}