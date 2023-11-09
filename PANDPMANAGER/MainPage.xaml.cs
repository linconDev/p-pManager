using PANDPMANAGER.ViewModel;

namespace PANDPMANAGER;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage(MainViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}

