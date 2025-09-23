using System;
using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	public static StringLocalizer Localizer { get; } = new StringLocalizer();
	public UserHttpService _userHttpService = new(new HttpClient());
	public BaseViewModel()
	{
	}

	[ObservableProperty]
	private int cultureCode;

	[ObservableProperty]
	private bool isEnabled = true;

	[ObservableProperty]
	private string title = string.Empty;

	[ObservableProperty]
	private Color mainColor = Color.FromRgba("#5bcec3");



}
