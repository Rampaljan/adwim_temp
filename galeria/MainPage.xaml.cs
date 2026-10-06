using galeria.ViewModels;

namespace galeria
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
        }
    }
}
