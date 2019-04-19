using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Planets
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanetsDetailPage : ContentPage
    {
        public PlanetsDetailPage(int id)
        {
            InitializeComponent();

            var planet = PlanetDataRepository.GetPlanetFromId(id);

            BindingContext = planet;
        }
    }
}