using CommunityToolkit.Mvvm.ComponentModel;
using ClientMobileApp.Services;

namespace ClientMobileApp.ViewModels;

public partial class LoginViewModel : BaseViewModel
{

	public LoginViewModel()
	{

	}

	
	public void LocalizeContent()
	{
		StringLocalizer.CultureCode = CultureCode;
		PickerTitleLang = Localizer.GetLocalizedString("pickerTitleLang", StringLocalizer.CultureCode);
		LabelWelcome = Localizer.GetLocalizedString("labelWelcome", StringLocalizer.CultureCode);
		LabelUsername = Localizer.GetLocalizedString("labelUsername", StringLocalizer.CultureCode);
		EntryUsernamePlaceholder = Localizer.GetLocalizedString("entryUsernamePlaceholder", StringLocalizer.CultureCode);
		LabelPassword = Localizer.GetLocalizedString("labelPassword", StringLocalizer.CultureCode);
		EntryPasswordPlaceholder = Localizer.GetLocalizedString("entryPassPlaceholder", StringLocalizer.CultureCode);
		ButtonLogin = Localizer.GetLocalizedString("buttonLogin", StringLocalizer.CultureCode);
		ButtonForgotPassword =	Localizer.GetLocalizedString("buttonForgotPassword", StringLocalizer.CultureCode);
		ButtonRegister = Localizer.GetLocalizedString("buttonRegister", StringLocalizer.CultureCode)	;
	}

	[ObservableProperty]
	private string pickerTitleLang = Localizer.GetLocalizedString("pickerTitleLang", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string labelWelcome = Localizer.GetLocalizedString("labelWelcome", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string labelUsername = Localizer.GetLocalizedString("labelUsername", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string entryUsernamePlaceholder = Localizer.GetLocalizedString("entryUsernamePlaceholder", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string labelPassword = Localizer.GetLocalizedString("labelPassword", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string entryPasswordPlaceholder = Localizer.GetLocalizedString("entryPassPlaceholder", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonLogin = Localizer.GetLocalizedString("buttonLogin", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonForgotPassword = Localizer.GetLocalizedString("buttonForgotPassword", StringLocalizer.CultureCode);
	[ObservableProperty]
	private string buttonRegister = Localizer.GetLocalizedString("buttonRegister", StringLocalizer.CultureCode);
}
