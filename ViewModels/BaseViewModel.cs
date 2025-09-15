using System;
using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	public StringLocalizer Localizer { get; } = new StringLocalizer();
	public BaseViewModel()
	{
		
	}

	[ObservableProperty]
	private bool isBusy;

	[ObservableProperty]
	private string title = string.Empty;



}
