namespace MauiShellReuseTest;

public partial class Page2 : ContentPage
{
	int count = 0;

	public Page2()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		count++;
		pagecount.Text = $"Count: {count}.  Should always be 1.";
	}

	private async void OnClicked(object sender, EventArgs e)
	{
        await Shell.Current.GoToAsync("//Page1");
    }
}

