namespace PagesDemo;

public partial class NewPage1 : FlyoutPage
{
	public NewPage1()
	{
		InitializeComponent();
		MainPage = new NavigationPage (new FlyoutPageDemo());
	}
}