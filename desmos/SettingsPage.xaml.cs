using desmos.ViewModels;

namespace desmos;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(MainViewModel VM)
	{
		InitializeComponent();
        BindingContext = VM;
    }
}