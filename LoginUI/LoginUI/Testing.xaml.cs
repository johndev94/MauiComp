using Windows.Security.Cryptography.Core;

namespace LoginUI;

public partial class Testing : ContentPage
{
	public const double MyFontSize = 25;
	public Testing()
	{
		InitializeComponent();
		btnTest.Clicked += OnBtnTest_Clicked;
	}
	public void OnBtnTest_Clicked(object sender, EventArgs e)
	{
		textTest.Text = "You clicked the button";
	}
}
public class GlobalFontSizeExtension : IMarkupExtension
{
	public object ProvideValue(IServiceProvider serviceProvider)
	{
		return Testing.MyFontSize;
	}
}