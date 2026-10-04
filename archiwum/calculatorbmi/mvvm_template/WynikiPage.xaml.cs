using mvvm_template.ViewModels;

namespace mvvm_template
{
    public partial class WynikiPage : ContentPage
    {
        public WynikiPage(WynikiViewModel wVM)
        {
            InitializeComponent();
            BindingContext = wVM;
        }
    }
}