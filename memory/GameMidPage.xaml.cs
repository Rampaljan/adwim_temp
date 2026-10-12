using memory.ViewModels;

namespace memory
{
    public partial class GameMidPage : ContentPage
    {
        public GameMidPage(GameMidViewModel VM)
        {
            InitializeComponent();
            BindingContext = VM;
        }

    }
}
