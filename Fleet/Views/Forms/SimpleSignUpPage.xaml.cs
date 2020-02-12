using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Fleet.Views.Forms
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleSignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSignUpPage" /> class.
        /// </summary>
        public SimpleSignUpPage()
        {
            InitializeComponent();
        }

        async void SfButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Fleet.Views.Forms.SimpleLoginPage());
        }

        async void SfButton_Clicked_1(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Fleet.Views.Forms2.SimpleSignUpPage2());
        }
    }
}