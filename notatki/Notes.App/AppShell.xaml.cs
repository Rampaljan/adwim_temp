using Notes.App.ViewModels;

namespace Notes.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("AddNote", typeof(AddNote));
            Routing.RegisterRoute("AddCategory", typeof(AddCategory));
            Routing.RegisterRoute("DisplayClickedNote", typeof(DisplayClickedNote));

        }
    }
}
