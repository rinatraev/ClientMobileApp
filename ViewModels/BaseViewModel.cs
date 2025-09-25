using System;
using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	public UserHttpService _userHttpService = new();
	public BaseViewModel()
	{
		AppCultureCode = ApplicationMockDataProvider.AppCultureCode;
	}
	
	[ObservableProperty]
	private int appCultureCode;
	partial void OnAppCultureCodeChanged(int value)
	{
		ApplicationMockDataProvider.AppCultureCode = value;
	}

	[ObservableProperty]
	private bool isEnabled = true;

	[ObservableProperty]
	private string title = string.Empty;

	[ObservableProperty]
	private Color mainColor = Color.FromRgba("#5bcec3");

	public virtual void LocalizeContent() { }

}
