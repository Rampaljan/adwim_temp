using kontrolki.ViewModels;

namespace kontrolki
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
