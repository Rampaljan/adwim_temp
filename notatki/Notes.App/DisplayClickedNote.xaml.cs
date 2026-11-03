using Notes.App.ViewModels;
namespace Notes.App;

public partial class DisplayClickedNote : ContentPage
{
	public DisplayClickedNote(DisplayClickedNoteViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}