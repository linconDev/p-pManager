using PANDPMANAGER.ViewModel;

namespace PANDPMANAGER;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}