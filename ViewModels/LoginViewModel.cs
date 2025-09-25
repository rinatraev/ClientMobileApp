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
		this.IsPassword = true;
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<LoginPageLocalizedTexts>();
	}

	
	// UI
	[ObservableProperty]
	private string username = string.Empty;
	[ObservableProperty]
	private string password = string.Empty;
	[ObservableProperty]
	private bool isPassword;

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
		if(string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
		{ 
			Application.Current?.MainPage?.DisplayAlert(LocalizedTexts.LogPloginAlertTitle, LocalizedTexts.LogPloginAlertMessage, "Ok");
			return;
		}
		var content = _userHttpService.GetHttpContent(Username, Password);
		var response = false;
		try
		{
			response = await _userHttpService.LoginAsync(content);
		}
		catch (Exception ex)
		{
			await Application.Current?.MainPage?.DisplayAlert("Ошибка", ex.Message, "Ок");
			return;
		}
		if (!response)
		{
			Application.Current?.MainPage?.DisplayAlert("Не получилось", "Повторите попытку", "Ок");
			return;
		}
		await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
	}
	[RelayCommand]
	private async Task SkipAuthorizationAsync()
	{
		await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
	}
	[RelayCommand]
	private async Task ForgotPasswordAsync()
	{
		await Application.Current.MainPage.DisplayAlert("Забыли пароль?", "Обратитесь к администратору", "Ок");
	}
	[RelayCommand]
	private async Task GoToRegisterPageAsync()
	{
		await Application.Current.MainPage.Navigation.PushAsync(new RegisterPage());
	}
}
