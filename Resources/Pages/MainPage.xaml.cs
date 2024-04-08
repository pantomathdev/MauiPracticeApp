namespace MauiPracticeApp
{
	public partial class MainPage : ContentPage
	{
		static int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;

			if (count == 1)
				CounterBtn.Text = $"Clicked {count} time";
			else
				CounterBtn.Text = $"Clicked {count} times";
			
			SemanticScreenReader.Announce(CounterBtn.Text);
		}

		private void OnResetClicked(object sender, EventArgs e)
		{
			count = 0;
			CounterBtn.Text = $"Clicked {count} times";
		}

		private void OnCheckedChanged(object sender, EventArgs e)
		{
			if (RadioBtn.IsChecked)
			{
				CheckText.Text = "Radio button is checked";
			}
			else
			{
				CheckText.Text =  "Radio button isn't checked";
			}
		}

		private void RadioBtn_CheckedChanged(object sender, CheckedChangedEventArgs e)
		{

		}
	}

}
