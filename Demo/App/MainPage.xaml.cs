using App.Pages;

namespace App;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	async void BasicViewerBtn_Clicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new BasicViewerPage());
	}
}