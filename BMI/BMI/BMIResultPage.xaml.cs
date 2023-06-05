namespace BMI;

public partial class BMIResultPage : ContentPage
{
	public BMIResultPage(double bmi)
	{
		InitializeComponent();
		LblBMI.Text = $"{bmi:F1}";
		LblBMIMessage.Text = $"Your're {GetResult(bmi)}";
	}

    private string GetResult(double bmi)
    {
       if(bmi >= 25)
		{
			return "Overweigt";
		}
	   else if(bmi > 18.5)
		{
			return "Normal";
		}
	   else
		{
			return "Underweight";
		}
    }
}