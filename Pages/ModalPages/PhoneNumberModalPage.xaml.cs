namespace ClientMobileApp.Pages.ModalPages;

public partial class PhoneNumberModalPage : ContentPage
{
	public PhoneNumberModalPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		var vm = this.BindingContext;
		Application.Current.MainPage.Navigation.PushModalAsync(new EntryDataModalPage() { BindingContext = vm });
    }
}