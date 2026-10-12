using memory.ViewModels;

namespace memory
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
