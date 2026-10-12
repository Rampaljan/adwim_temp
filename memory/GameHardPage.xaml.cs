using memory.ViewModels;

namespace memory
{
    public partial class GameHardPage : ContentPage
    {
        public GameHardPage(GameHardViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
        }

    }
}
