using Notes.App.ViewModels;
namespace Notes.App;

public partial class AddCategory : ContentPage
{
	public AddCategory(AddCategoryViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}