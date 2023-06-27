namespace Flyout_Behavior;

public partial class AppShell : Shell
{
	public AppShell()
	{	
		InitializeComponent();
	}

	private void OnGridATapped(object sender, TappedEventArgs e)
	{
		//throw new NotImplementedException();
  		Shell.Current.FlyoutIsPresented = true;
	}

	private void MenuItem_OnClicked(object sender, EventArgs e)
	{
		//int aaa;
  		return;
	}

    void OnButtonItemClicked(System.Object sender, System.EventArgs e)
    {
		Shell.Current.FlyoutIsPresented = true;
    }
}

