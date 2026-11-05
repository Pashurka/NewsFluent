using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Networking; 

namespace NewsFluent;

public partial class LoginPage : ContentPage
{
    private const string FirebaseApiKey = "AIzaSyBOT1HXPcZQZid5WlMkXEQgZU1ISE9Ycx4";

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string login = loginEntry.Text?.Trim();
        string password = passwordEntry.Text;

        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
        {
            messageLabel.Text = "Будь ласка, заповніть усі поля.";
            messageLabel.IsVisible = true;
            return;
        }

        try
        {
            // Перевірка наявності інтернет-з'єднання
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await DisplayAlert("Помилка", "Відсутнє інтернет-з'єднання. Будь ласка, перевірте ваші налаштування.", "OK");
                return;
            }

            bool success = await TryLoginAsync(login, password);
            if (success)
            {
                messageLabel.IsVisible = false;
                await DisplayAlert("Успіх", "Ви увійшли!", "OK");
                await Navigation.PushAsync(new MainPage());
            }
            else
            {
                messageLabel.Text = "Невірний логін або пароль.";
                messageLabel.IsVisible = true;
            }
        }
        catch (Exception ex)
        {
            // Загальна обробка помилок
            await DisplayAlert("Помилка", $"Сталася помилка: {ex.Message}", "OK");
        }
    }

    private async Task<bool> TryLoginAsync(string email, string password)
    {
        var httpClient = new HttpClient();

        var payload = new
        {
            email,
            password,
            returnSecureToken = true
        };

        string jsonPayload = JsonSerializer.Serialize(payload);
        var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

        string url = $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={FirebaseApiKey}";

        var response = await httpClient.PostAsync(url, content);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var result = JsonSerializer.Deserialize<FirebaseAuthResponse>(json);
            // Можна зберегти result.idToken, result.email тощо
            return true;
        }

        return false;
    }

    // Для парсингу JSON-відповіді
    private class FirebaseAuthResponse
    {
        public string idToken { get; set; }
        public string email { get; set; }
        public string refreshToken { get; set; }
        public string expiresIn { get; set; }
        public string localId { get; set; }
    }
}
