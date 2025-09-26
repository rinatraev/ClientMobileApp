

using ClientMobileApp.Models.PageLocalizedTexts;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ClientMobileApp.Services;

public static class StringLocalizer
{
	private static readonly ResourceManager _resourceManager = new ResourceManager("ClientMobileApp.Resources.Dictionary.Strings", typeof(StringLocalizer).Assembly);
	public static string GetLocalizedString(string key, int languageCode = 0, params object[] args)
	{
		CultureInfo.CurrentUICulture = new CultureInfo(languageCode == 1 ? "uz" : "ru");
		string value = _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? key;
		if (args != null && args.Length > 0)
			return string.Format(value, args);

		return value;
	}
	public static T GetLocalizedTexts<T>() where T : new()
	{
		var RequestedPageTexts = new T();
		var properties = typeof(T).GetProperties();
		foreach (var prop in properties)
		{
			if (prop.PropertyType == typeof(string))
			{
				var localizedValue = GetLocalizedString(prop.Name, ApplicationMockDataProvider.AppCultureCode);
				prop.SetValue(RequestedPageTexts, localizedValue);
			}
		}
		return RequestedPageTexts;
	}
}
