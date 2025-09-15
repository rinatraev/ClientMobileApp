using System;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ClientMobileApp.ViewModels;

public partial class BaseViewModel : ObservableObject
{

	public BaseViewModel()
	{
		
	}

	[ObservableProperty]
	private bool isBusy;

	[ObservableProperty]
	private string title = string.Empty;



}
