
using todoapp.ViewModels;
using todoapp.ViewModels;

namespace todoapp
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

