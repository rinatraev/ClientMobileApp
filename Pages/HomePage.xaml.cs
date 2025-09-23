using System.Text;

namespace ClientMobileApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		String pages = string.Empty;
		foreach (Page p in Application.Current?.MainPage?.Navigation.NavigationStack)
		{
			pages += p.ToString();
		}
		metka.Text = pages;
	}
}