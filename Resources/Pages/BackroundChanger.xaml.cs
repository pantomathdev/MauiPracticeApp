namespace MauiPracticeApp.Resources.Pages;

public partial class BackroundChanger : ContentPage
{
	public BackroundChanger()
	{
		InitializeComponent();
		luminosityLabel.Text += sliderComponent.Value;
	}

	public void RedButtonClicked(object sender, EventArgs e)
	{
		sliderComponent.Value = 0;
		this.BackgroundColor = Colors.Red;
	}
	public void BlueButtonClicked(object sender, EventArgs e)
	{
		sliderComponent.Value = 0;
		this.BackgroundColor = Colors.Blue;
	}
	public void YellowButtonClicked(object sender, EventArgs e)
	{
		sliderComponent.Value = 0;
		this.BackgroundColor = Colors.Yellow;
	}

	public void GreenButtonClicked(object sender, EventArgs e)
	{
		sliderComponent.Value = 0;
		this.BackgroundColor = Colors.Green;
	}

	public void DefaultButtonClicked(object sender, EventArgs e)
	{
		sliderComponent.Value = 0;
		BackgroundColor = Colors.DarkGrey;
	}
	private void SfSliderLight_ValueChanged(object sender, Syncfusion.Maui.Sliders.SliderValueChangedEventArgs e)
	{
		float hue, saturation, lightness = 0f;
		BackgroundColor.ToHsl(out hue, out saturation, out lightness);
		float lightnessChange = (float)(e.NewValue-e.OldValue)/100f;

		lightness += lightnessChange;

		lightness = Math.Clamp(lightness, 0f, 1f);

		BackgroundColor = Color.FromHsla(hue, saturation, lightness);

		luminosityLabel.Text = "Luminosity:"+Math.Round(sliderComponent.Value,2);
	}
}