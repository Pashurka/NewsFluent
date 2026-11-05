namespace NewsFluent;

public partial class UserManagementPage : ContentPage
{
	public UserManagementPage()
	{
		InitializeComponent();
	}

    private void OnSendMessageClicked(object sender, EventArgs e)
    {
        // Логіка для надсилання повідомлення користувачу
        DisplayAlert("Повідомлення", "Функція надсилання ще не реалізована", "OK");
    }

    private void OnToggleBlockClicked(object sender, EventArgs e)
    {
        // Логіка для блокування/розблокування
        DisplayAlert("Блокування", "Функція блокування ще не реалізована", "OK");
    }

    private void OnDeleteUserClicked(object sender, EventArgs e)
    {
        // Логіка для видалення користувача
        DisplayAlert("Видалення", "Функція видалення ще не реалізована", "OK");
    }
}