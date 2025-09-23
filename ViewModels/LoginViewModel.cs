using CommunityToolkit.Mvvm.ComponentModel;
using ClientMobileApp.Services;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using ClientMobileApp.Pages;

namespace ClientMobileApp.ViewModels;

public partial class LoginViewModel : BaseViewModel
{

	public LoginViewModel()
	{

	}
	// UI
	[ObservableProperty]
	private string pickerTitleLang = Localizer.GetLocalizedString("pickerTitleLang", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonSkip = Localizer.GetLocalizedString("buttonSkip", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string labelWelcome = Localizer.GetLocalizedString("labelWelcome", StringLocalizer.CultureCode);
	//Username area
	[ObservableProperty]
	private string labelUsername = Localizer.GetLocalizedString("labelUsername", StringLocalizer.CultureCode);
	//EntryUsername
	[ObservableProperty]
	private string entryUsernamePlaceholder = Localizer.GetLocalizedString("entryUsernamePlaceholder", StringLocalizer.CultureCode);
	[ObservableProperty]
	public string username = string.Empty;
	//Password area
	[ObservableProperty]
	private string labelPassword = Localizer.GetLocalizedString("labelPassword", StringLocalizer.CultureCode);
	//EntryPassword
	[ObservableProperty]
	private string entryPasswordPlaceholder = Localizer.GetLocalizedString("entryPassPlaceholder", StringLocalizer.CultureCode);
	[ObservableProperty]
	public string password = string.Empty;

	[ObservableProperty]
	private string buttonLogin = Localizer.GetLocalizedString("buttonLogin", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonForgotPassword = Localizer.GetLocalizedString("buttonForgotPassword", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonRegister = Localizer.GetLocalizedString("buttonRegister", StringLocalizer.CultureCode);

	// BaseViewModel properties: IsBusy:bool, Title:string, CultureCode:int, MainColor:Color 
	public void LocalizeContent()
	{
		IsEnabled = false;
		StringLocalizer.CultureCode = CultureCode;
		PickerTitleLang = Localizer.GetLocalizedString("pickerTitleLang", StringLocalizer.CultureCode);
		ButtonSkip = Localizer.GetLocalizedString("buttonSkip", StringLocalizer.CultureCode);
		LabelWelcome = Localizer.GetLocalizedString("labelWelcome", StringLocalizer.CultureCode);
		LabelUsername = Localizer.GetLocalizedString("labelUsername", StringLocalizer.CultureCode);
		EntryUsernamePlaceholder = Localizer.GetLocalizedString("entryUsernamePlaceholder", StringLocalizer.CultureCode);
		LabelPassword = Localizer.GetLocalizedString("labelPassword", StringLocalizer.CultureCode);
		EntryPasswordPlaceholder = Localizer.GetLocalizedString("entryPassPlaceholder", StringLocalizer.CultureCode);
		ButtonLogin = Localizer.GetLocalizedString("buttonLogin", StringLocalizer.CultureCode);
		ButtonForgotPassword =	Localizer.GetLocalizedString("buttonForgotPassword", StringLocalizer.CultureCode);
		ButtonRegister = Localizer.GetLocalizedString("buttonRegister", StringLocalizer.CultureCode);
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
