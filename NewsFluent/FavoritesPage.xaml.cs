namespace NewsFluent;

public partial class FavoritesPage : ContentPage
{
    public FavoritesPage()
    {
        InitializeComponent();

        var favoriteNews = new List<FavoriteNews>
        {
            new FavoriteNews("ІТ-стартапи в Україні", "Запуск нової програми підтримки стартапів в Україні.",
                             DateTime.Now.AddDays(-1), "Це велика можливість для молодих підприємців!"),
            new FavoriteNews("Міжнародна нагорода для застосунку", "Новий український застосунок для подорожей отримав міжнародну нагороду.",
                             DateTime.Now.AddDays(-2), "Цей застосунок справді змінює досвід подорожей."),
            new FavoriteNews("Курс з AI", "Новий курс з штучного інтелекту для розробників.",
                             DateTime.Now.AddDays(-3), "Мені подобається цей курс. Вже зареєструвався!"),
            new FavoriteNews("Smart-парк у Києві", "У Києві відкрили перший smart-парк для мешканців.",
                             DateTime.Now.AddDays(-5), ""),
            new FavoriteNews("Інвестиції в український стартап", "Український стартап залучив $5 млн інвестицій.",
                             DateTime.Now.AddDays(-7), "Вражаючий успіх для української технології."),
            new FavoriteNews("Перемога на хакатоні", "Українська команда виграла міжнародний хакатон в Берліні.",
                             DateTime.Now.AddDays(-10), ""),
            new FavoriteNews("Новий AI-помічник у Chrome", "Chrome інтегрує новий AI-помічник для користувачів.",
                             DateTime.Now.AddDays(-12), "Потрібно буде спробувати новий AI, він обіцяє бути корисним."),
            new FavoriteNews("Стажування в IT", "Новий сервіс для пошуку стажувань в галузі IT.",
                             DateTime.Now.AddDays(-14), "Це саме те, що мені потрібно, вже подала заявку."),
            new FavoriteNews("Новий офіс Microsoft в Україні", "Microsoft відкриває новий офіс в Україні.",
                             DateTime.Now.AddDays(-20), "Це велика перемога для України!"),
            new FavoriteNews("Захищене шифрування в месенджері", "Новий український месенджер тестує захищене шифрування.",
                             DateTime.Now.AddDays(-25), "")
        };

        // Підставляємо у CollectionView
        FavoritesCollectionView.ItemsSource = favoriteNews;
    }

    class FavoriteNews
    {
        public string NewsTitle { get; set; }
        public string NewsSummary { get; set; }
        public DateTime DateTime { get; set; }
        public string UserComment { get; set; }

        public FavoriteNews(string newsTitle, string newsSummary, DateTime dateTime, string userComment)
        {
            NewsTitle = newsTitle;
            NewsSummary = newsSummary;
            DateTime = dateTime;
            UserComment = userComment;
        }
    }
}
