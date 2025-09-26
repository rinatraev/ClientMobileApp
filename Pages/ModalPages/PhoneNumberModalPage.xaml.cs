namespace ClientMobileApp.Pages.ModalPages;

public partial class PhoneNumberModalPage : ContentPage
{
	public PhoneNumberModalPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		Application.Current.MainPage.Navigation.PushModalAsync(new EntryDataModalPage());
    }
}