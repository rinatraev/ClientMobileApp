

using System.Globalization;
using System.Resources;

namespace ClientMobileApp.Services;

public class StringLocalizer
{
	private readonly ResourceManager _resourceManager;
	public StringLocalizer()
	{
		_resourceManager = new ResourceManager("ClientMobileApp.Resources.Dictionary.Strings", typeof(StringLocalizer).Assembly);
	}
	public string GetLocalizedString(string key, int languageCode = 0, params object[] args)
	{
		CultureInfo.CurrentUICulture = new CultureInfo(languageCode == 1 ? "uz" : "ru");
		string value = _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? key;
		if (args != null && args.Length > 0)
			return string.Format(value, args);

		return value;
	}
}
