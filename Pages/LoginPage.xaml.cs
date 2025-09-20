
using ClientMobileApp.ViewModels;
namespace ClientMobileApp.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

	private void LoginPage_NavigatedTo(object sender, NavigatedToEventArgs e)
	{
		if (sender is ContentPage page)
			if (Content.BindingContext is LoginViewModel loginViewModel)
				loginViewModel.LocalizeContent();
	}

	private void PickerIndexChanged(object sender, EventArgs e)
	{
		Console.WriteLine("PickerEventHandler --------=======");
		if(this.BindingContext is LoginViewModel loginVM)
			loginVM.LocalizeContent();
	}
}