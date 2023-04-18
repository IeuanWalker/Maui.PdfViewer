namespace App.Controls;

public partial class CustomButton : ContentView
{
	public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomButton), string.Empty);

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public event EventHandler? Clicked;

	void StateButton_Clicked(object sender, EventArgs e)
	{
		Clicked?.Invoke(this, EventArgs.Empty);
	}
	public CustomButton()
	{
		InitializeComponent();
	}
}