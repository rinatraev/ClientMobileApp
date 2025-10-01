using ClientMobileApp.Pages;
using ClientMobileApp.Services;
using ClientMobileApp.ViewModels;

namespace ClientMobileApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        var service = new UserHttpService();
        var viewModel = new LoginViewModel(service);
		MainPage = new NavigationPage(new LoginPage(viewModel));
    }
}
