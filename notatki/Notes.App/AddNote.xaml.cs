using Notes.App.ViewModels;
namespace Notes.App;

public partial class AddNote : ContentPage
{
	public AddNote(AddCategoryViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}