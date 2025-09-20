using System;
using ClientMobileApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	public static StringLocalizer Localizer { get; } = new StringLocalizer();
	public BaseViewModel()
	{
		
	}

	[ObservableProperty]
	private int cultureCode;

	[ObservableProperty]
	private bool isBusy;

	[ObservableProperty]
	private string title = string.Empty;

	[ObservableProperty]
	private Color navigationBarColor = Colors.Transparent;

	[ObservableProperty]
	private Color navigationBarTextColor = Colors.Black;

	[ObservableProperty]
	private bool isNavigationBarVisible = false;

	[ObservableProperty]
	private Color mainColor = Color.FromRgba("#5bcec3");



}
