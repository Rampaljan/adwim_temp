using Notes.App.ViewModels;
namespace Notes.App;

public partial class NotesList : ContentPage
{
	public NotesList(NotesListViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}