using CommunityToolkit.Maui.Views;

namespace MauiComm_IssuePopup;

public partial class MainPage : ContentPage
{
	private Indicator pIndicator = null;

	public MainPage()
	{
		InitializeComponent();
	}

    private async void btn_Clicked(object sender, EventArgs e)
    {
		this.ShowIndicator();
		await Task.Delay(3000);
		this.CloseIndicator();
    }

	private void ShowIndicator()
	{
		if (pIndicator == null)
		{
			pIndicator = new Indicator();
			this.ShowPopup(pIndicator);
		}
	}

	private void CloseIndicator()
	{
		if (pIndicator != null)
		{
			pIndicator.Close();
			pIndicator = null;
		}
	}
}

