using desmos.ViewModels;

namespace desmos
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;

            // Tworzenie okna z ustawieniami
            var settingsWindow = new Window(new SettingsPage(VM)) // <-- SettingsPage to po prostu samodzielna strona XAML
            {
                Title = "Settings",
                Width = 400,
                Height = 550
            };

            Application.Current.OpenWindow(settingsWindow);


        }

    }
}
