using Xamarin.Forms;

namespace Planets
{
    public class PlanetsMasterDetail : MasterDetailPage
    {
        public PlanetsMasterDetail()
        {
            MasterBehavior = MasterBehavior.Split;

            var master = new PlanetsMasterPage();

            Master = master;

            master.MasterItemSelected += MasterItemSelected;

            MasterItemSelected(this, 0);
        }

        void MasterItemSelected(object sender, int id)
        {
            Detail = new NavigationPage (new PlanetsDetailPage(id));

            if(Device.Idiom == TargetIdiom.Phone)
                IsPresented = false;
        }
    }
}