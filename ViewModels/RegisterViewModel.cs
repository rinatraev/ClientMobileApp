using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ClientMobileApp.Models.PageLocalizedTexts;
using ClientMobileApp.Pages;

namespace ClientMobileApp.ViewModels;

public partial class RegisterViewModel : BaseViewModel
{

	[ObservableProperty]
	private RegisterPageLocalizedTexts localizedTexts;
	public RegisterViewModel(UserHttpService httpservice):base(httpservice)
	{
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<RegisterPageLocalizedTexts>();
	}

	[ObservableProperty]
	private string phoneNumber = string.Empty;
	[ObservableProperty]
	private string smsCode = string.Empty;
	[ObservableProperty]
	private string username = string.Empty;
	[ObservableProperty]
	private string password = string.Empty;
	[ObservableProperty]
	private string confirmPassword = string.Empty;
	[ObservableProperty]
	private bool termsChecked = false;
	[RelayCommand]
	private async Task ShowSmsCode()
	{
		await Application.Current.MainPage.DisplayAlert("SMS code", "2234", "Ok");
	}
	[RelayCommand]
	private async Task PopModalPage()
	{
		await Application.Current.MainPage.Navigation.PopModalAsync();
	}
	[RelayCommand]
	private async Task RegisterAsync()
	{
		// var content = _userHttpService.GetHttpContent(Username, Password, PhoneNumber);
		bool response = false;
		/* test mode with no connection to backend
		try
		{
			response = await _userHttpService.RegisterAsync(content);
		}catch(Exception ex)
		{
			Application.Current.MainPage.DisplayAlert(LocalizedTexts.P02MS00, ex.Message, "Ok");
		}
		*/
		if (response)
		{
			await Application.Current.MainPage.DisplayAlert(LocalizedTexts.P02MS01, LocalizedTexts.P02MS02, "Ok");
			while (Application.Current.MainPage.Navigation.ModalStack.Count > 0)
			{
				Application.Current.MainPage.Navigation.PopModalAsync();
			}
		}
		
		await Application.Current.MainPage.DisplayAlert(LocalizedTexts.P02MS01, LocalizedTexts.P02MS02, "Ok");
		while (Application.Current.MainPage.Navigation.ModalStack.Count > 0)
		{
			Application.Current.MainPage.Navigation.PopModalAsync();
		}
	}
	public override void LocalizeContent()
	{
		IsBusy = false;
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<RegisterPageLocalizedTexts>();
		IsBusy = true;
	}
}
