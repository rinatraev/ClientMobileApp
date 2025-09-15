using ClientMobileApp.Services;

namespace ClientMobileApp.Pages;

public partial class SplashPage : ContentPage
{
	
	public SplashPage()
	{
		InitializeComponent();
		var str = new StringLocalizer();
		Test.Text = str.GetLocalizedString("_001", 1, "Rinat");
	}
}