using CommunityToolkit.Mvvm.ComponentModel;
using ClientMobileApp.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using ClientMobileApp.Pages;
using ClientMobileApp.Models.PageWordDictionaries;

namespace ClientMobileApp.ViewModels;

public partial class LoginViewModel : BaseViewModel
{
	[ObservableProperty]
	private LoginPageLocalizedTexts localizedTexts;
	public LoginViewModel()
	{
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<LoginPageLocalizedTexts>();
	}

	
	// UI
	[ObservableProperty]
	public string username = string.Empty;
	[ObservableProperty]
	public string password = string.Empty;


	// BaseViewModel properties: IsEnabled:bool, Title:string, CultureCode:int, MainColor:Color 
	public override void LocalizeContent() 
	{
		IsEnabled = false;
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<LoginPageLocalizedTexts>();
		IsEnabled = true;
	}

	[RelayCommand]
	private async Task LoginAsync()
	{
		/*var content = _userHttpService.GetHttpContent(Username, Password);
		var response = await _userHttpService.LoginAsync(content);
		if (response != null)
		{
			Application.Current?.MainPage?.DisplayAlert("Не получилось", "Повторите попытку", "Ок");
		}*/

		await Application.Current.MainPage.Navigation.PushAsync(new HomePage());

	}
	
}
