namespace LoginUI;

public class Login1 : ContentPage
{
	//create login button and VerticalStackLayou
	Button loginButton;
	VerticalStackLayout layout;
	public Login1()
	{
		this.BackgroundColor = Color.FromArgb("512bdf");
		//initialising VerticalStack and defining properties
		layout = new VerticalStackLayout
		{
			Margin = new Thickness(15, 15, 15, 15),
			Padding = new Thickness(30, 60, 30, 30),
			Children =
			{
				new Label {Text = "Please log in", FontSize = 30, TextColor = Color.FromRgb(255,255,100)},
				new Label {Text = "Username", TextColor = Color.FromRgb(255,255,100)},
				new Entry (),
				new Label {Text = "Password", TextColor = Color.FromRgb(255,255,100)},
				new Entry {IsPassword = true}

			}
		};

		loginButton = new Button { Text = "Login", BackgroundColor = Color.FromRgb(0, 148, 255) };
		//adding button to layout
		layout.Children.Add(loginButton);
		//setting content of the page to layout
		Content = layout;

		//When button is clicked go to method OnLoginBtnClicked
		loginButton.Clicked += OnLoginBtnClicked;
	}
	private async void OnLoginBtnClicked(object sender, EventArgs e)
	{
		Entry tempEntry = (Entry)this.layout.Children[2];
		await DisplayAlert("Login attempted", $"login attempted by {tempEntry.Text}", "OK");
	}
}