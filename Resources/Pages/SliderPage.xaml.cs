namespace MauiPracticeApp;

public partial class SliderPage : ContentPage
{
	public SliderPage()
	{
		InitializeComponent();
	}

	private void SliderComponent_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		this.Resources["SliderValueProperty"] = Math.Round(e.NewValue/100,2);
	}
}