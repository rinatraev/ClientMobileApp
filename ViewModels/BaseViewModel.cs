using System;
using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public abstract partial class BaseViewModel : ObservableObject
{
	public UserHttpService _userHttpService;
	public BaseViewModel(UserHttpService httpService)
	{
		_userHttpService = httpService;
		AppCultureCode = ApplicationMockDataProvider.AppCultureCode;
	}
	
	[ObservableProperty]
	private int appCultureCode;
	partial void OnAppCultureCodeChanged(int value)
	{
		ApplicationMockDataProvider.AppCultureCode = value;
	}

	[ObservableProperty]
	private bool isBusy = true;

	[ObservableProperty]
	private string title = string.Empty;

	[ObservableProperty]
	private Color mainColor = Color.FromRgba("#5bcec3");

	public virtual void LocalizeContent() { }

}
