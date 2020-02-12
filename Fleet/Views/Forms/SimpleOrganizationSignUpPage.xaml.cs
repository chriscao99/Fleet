using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Fleet.Views.Forms
{
    /// <summary>
    /// Page to sign in with user details.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SimpleOrganizationSignUpPage : SimpleSignUpPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSignUpPage" /> class.
        /// </summary>
        public SimpleOrganizationSignUpPage()
        {
            InitializeComponent();
        }

    }
}