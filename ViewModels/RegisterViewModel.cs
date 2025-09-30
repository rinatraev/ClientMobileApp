using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ClientMobileApp.Models.PageLocalizedTexts;

namespace ClientMobileApp.ViewModels;

public partial class RegisterViewModel : BaseViewModel
{

	[ObservableProperty]
	private RegisterPageLocalizedTexts localizedTexts;
	public RegisterViewModel()
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
	private async Task ShowSMSCode()
	{
		await Application.Current.MainPage.DisplayAlert("SMS code", "2234", "Ok");
	}
	[RelayCommand]
	private async Task PopModalPage()
	{
		await Application.Current.MainPage.Navigation.PopModalAsync();
	}
	public override void LocalizeContent()
	{
		IsBusy = false;
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<RegisterPageLocalizedTexts>();
		IsBusy = true;
	}
}
