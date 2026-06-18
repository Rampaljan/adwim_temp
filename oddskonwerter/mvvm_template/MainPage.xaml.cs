
using mvvm_template.ViewModels;

namespace mvvm_template
{
    public partial class MainPage : ContentPage
    {
        public MainPage (MainViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
        }

    }
}

