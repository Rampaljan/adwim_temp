using memory.ViewModels;

namespace memory
{
    public partial class GameEasyPage : ContentPage
    {
        public GameEasyPage(GameEasyViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
        }

    }
}
