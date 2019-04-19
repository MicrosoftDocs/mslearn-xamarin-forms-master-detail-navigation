using Astronomy.Pages;
using Xamarin.Forms;

namespace Astronomy
{
    public class AstronomyMasterDetailPage : MasterDetailPage
    {
        public AstronomyMasterDetailPage()
        {
            var master = new AstronomyMasterPage();

            if (Device.RuntimePlatform == Device.iOS)
                master.Icon = (FileImageSource)ImageSource.FromFile("nav-menu-icon.png");

            this.Master = master;

            this.MasterBehavior = MasterBehavior.Popover;

            this.Detail = new NavigationPage(new AboutPage());
        }
    }
}
