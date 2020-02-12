using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Fleet.Views.Forms2
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleSignUpPage2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSignUpPage2" /> class.
        /// </summary>
        public SimpleSignUpPage2()
        {
            InitializeComponent();
        }

        async void SfButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Fleet.Views.Forms.SimpleLoginPage());
        }
    }
}