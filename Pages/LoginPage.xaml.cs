
using ClientMobileApp.ViewModels;
namespace ClientMobileApp.Pages;

public partial class LoginPage : ContentPage
{
	
	public LoginPage(LoginViewModel loginViewModel)
	{
		InitializeComponent();
		BindingContext = loginViewModel;
	}
	private void PickerIndexChanged(object sender, EventArgs e)
	{
		if (this.BindingContext is LoginViewModel loginVM)
		{	
			loginVM.LocalizeContent();
		}
	}
}