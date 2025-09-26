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
	private bool termsChecked = false;
	[RelayCommand]
	private async Task showSMSCode()
	{
		await Application.Current.MainPage.DisplayAlert("SMS code", "2234", "Ok");
	}
	public override void LocalizeContent()
	{
		IsBusy = false;
		LocalizedTexts = StringLocalizer.GetLocalizedTexts<RegisterPageLocalizedTexts>();
		IsBusy = true;
	}
}
