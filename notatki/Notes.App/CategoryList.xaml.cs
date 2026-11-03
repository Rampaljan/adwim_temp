using Notes.App.ViewModels;
namespace Notes.App;

public partial class CategoryList : ContentPage
{
	public CategoryList(CategoryListViewModel VM)
	{
		InitializeComponent();
		BindingContext = VM;
	}
}