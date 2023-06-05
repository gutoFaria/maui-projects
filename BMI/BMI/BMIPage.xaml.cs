namespace BMI;

public partial class BMIPage : ContentPage
{
	public BMIPage()
	{
		InitializeComponent();
	}

    private void TapMale_Tapped(object sender, TappedEventArgs e)
    {
        FrameMale.BorderColor = Color.FromArgb("#0a0e29");
        FrameFemale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void TapFemale_Tapped(object sender, TappedEventArgs e)
    {
        FrameFemale.BorderColor = Color.FromArgb("#0a0e29");
        FrameMale.BorderColor = Color.FromArgb("#fdfdfd");
    }

    private void BtnCalculateBMI_Clicked(object sender, EventArgs e)
    {
        double height = double.Parse(LblHeight.Text);
        double weight = double.Parse(LblWeight.Text);

        double bmi = (weight / height / height) * 1000;
        //DisplayAlert("Your BMI is", bmi.ToString(), "cancel");
        Navigation.PushAsync(new BMIResultPage(bmi));
    }
}