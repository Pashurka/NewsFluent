namespace NewsFluent;

public partial class CommentsPage : ContentPage
{
    public CommentsPage()
    {
        InitializeComponent();

        var comments = new List<Comment>
        {
            new Comment("news_fan01 | 2025-04-14 10:32", "В Україні запустили нову програму підтримки ІТ-стартапів.", "Чудова ініціатива! Сподіваюся, це допоможе молодим розробникам."),
            new Comment("techlover2023 | 2025-04-14 09:12", "Новий застосунок для подорожей отримав міжнародну нагороду.", "Користуюсь цим застосунком — він дійсно зручний!"),
            new Comment("olena_dev | 2025-04-13 17:45", "Відкрито реєстрацію на новий курс з AI.", "Зареєструвалась! Виглядає дуже цікаво."),
            new Comment("max_reader | 2025-04-13 12:00", "У Києві відкрили перший smart-парк.", "Обов'язково навідаюсь! Виглядає футуристично."),
            new Comment("anna.comments | 2025-04-13 08:21", "Український стартап залучив $5 млн інвестицій.", "Пишаюсь нашими розробниками!"),
            new Comment("sportfan45 | 2025-04-12 20:15", "Українська команда виграла хакатон у Берліні.", "Браво! Так тримати!"),
            new Comment("code_master | 2025-04-12 17:49", "У Chrome з'явився вбудований AI-помічник.", "Вже протестував — працює непогано!"),
            new Comment("natalka_news | 2025-04-12 14:08", "З'явився новий сервіс для пошуку стажування в IT.", "Це якраз те, що мені потрібно. Дякую за новину!"),
            new Comment("denys_dev | 2025-04-11 19:20", "Microsoft відкриває новий офіс в Україні.", "Це крута новина для ринку праці!"),
            new Comment("yulia_test | 2025-04-11 09:55", "Новий український месенджер тестує захищене шифрування.", "Безпека — це дуже важливо, дякую за роботу!")
        };

        // Підставляємо у CollectionView
        CommentsCollectionView.ItemsSource = comments;
    }

    class Comment
    {
        public string UserInfo { get; set; }
        public string NewsSummary { get; set; }
        public string UserComment { get; set; }

        public Comment(string userInfo, string newsSummary, string userComment)
        {
            UserInfo = userInfo;
            NewsSummary = newsSummary;
            UserComment = userComment;
        }
    }
}

