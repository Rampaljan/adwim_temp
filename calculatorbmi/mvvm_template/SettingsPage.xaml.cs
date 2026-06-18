namespace mvvm_template;
using mvvm_template.ViewModels;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel sVM)
	{
		InitializeComponent();
        BindingContext = sVM;
    }
}