using Xamarin.Forms;

namespace Loginsamaple
{
    public partial class LoginPage : ContentPage
    {
        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navi  (new LoginsamaplePage());
        }

        public LoginPage()
        {
            InitializeComponent();
        }
    }
}
