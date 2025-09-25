using System;
using System.Net.Http.Json;
using ClientMobileApp.Models;
namespace ClientMobileApp.Services;

public class UserHttpService
{
	private readonly HttpClient _httpClient;
	public UserHttpService()
	{
		_httpClient = new HttpClient();
		_httpClient.BaseAddress = new Uri("https://known-settling-joey.ngrok-free.app/api/");
	}
	public HttpContent GetHttpContent(string username, string password)
	{
		var user = new UserDto
		{
			Username = username,
			Password = password
		};
		var json = System.Text.Json.JsonSerializer.Serialize(user);
		var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
		return content;
	}
	public async Task<bool> LoginAsync(HttpContent content)
	{
		var response = await _httpClient.PostAsync("auth/login", content);

		if (response.IsSuccessStatusCode)
		{
			var tokens = await response.Content.ReadFromJsonAsync<TokenDto>();
			Preferences.Set("accessToken", tokens?.AccessToken ?? string.Empty);
			Preferences.Set("refreshToken", tokens?.RefreshToken ?? string.Empty);
			return true;
		}
		return false;
	}
	public async Task<TokenDto?> RegisterAsync(HttpContent content)
	{
		//_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
		var response = await _httpClient.PostAsync("auth/register", content);
		if (response.IsSuccessStatusCode)
		{
			var tokens = await response.Content.ReadFromJsonAsync<TokenDto>();
			return tokens;
		}
		return null;
	}
}
