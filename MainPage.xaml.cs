using CommunityToolkit.Maui.Views;

namespace MauiButtonAlignBug
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowPopup_Clicked(object sender, EventArgs e)
        {
            TestPopup testPopup = new TestPopup();
            Application.Current!.MainPage!.ShowPopup(testPopup);
        }
    }

}
