using System.Collections.Generic;

namespace Planets
{
    public static class PlanetDataRepository
    {
        public static IList<Planet> Planets { get; private set; }

        static PlanetDataRepository()
        {
            Planets = new List<Planet>();

            for (int i = 0; i < planetsData.GetLength(0); i++)
            {
                int index = 0;

                var planet = new Planet()
                {
                    Id = i,
                    Image = planetsData[i, index].ToLower() + ".png",
                    Name = planetsData[i, index++],
                    Mass = double.Parse(planetsData[i, index++], System.Globalization.CultureInfo.InvariantCulture),
                    EquitorialDiameter = double.Parse(planetsData[i, index++], System.Globalization.CultureInfo.InvariantCulture),
                    OrbitalPeriod = double.Parse(planetsData[i, index++], System.Globalization.CultureInfo.InvariantCulture),
                    RotationPeriod = double.Parse(planetsData[i, index++], System.Globalization.CultureInfo.InvariantCulture),
                    ConfirmedMoons = double.Parse(planetsData[i, index++], System.Globalization.CultureInfo.InvariantCulture),
                    HasRings = bool.Parse(planetsData[i, index++]),
                    Atmosphere = planetsData[i, index],
                };

                Planets.Add(planet);
            }
        }

        public static Planet GetPlanetFromId(int id)
        {
            return Planets[id];
        }

        static string[,] planetsData =
        {   
            {"Mercury", "0.382", "0.06", "0.24", "58.64", "0", "false", "minimal" },
            {"Venus", "0.949", "0.82", "0.62", "-243.02", "0", "false", "Carbon Dioxide, Nitrogen" },
            {"Earth", "1.00", "1.00", "1.00", "1.00", "1", "false", "Nitrogen, Oxygen, Argon" },
            {"Mars", "0.532", "0.11", "1.88", "1.03", "2", "false", "Carbon Dioxide, Nigrogen, Argon" },
            {"Jupiter", "11.209", "317.8", "11.86", "0.41", "69", "true", "Hydrogen, Helium" },
            {"Saturn", "9.449", "95.2", "29.46", "0.43", "62", "true", "Hydrogen, Helium" },
            {"Uranus", "4.007", "14.6", "84.01", "-0.72", "27", "true", "Hydrogen, Helium, Methane" },
            {"Neptune", "3.993", "17.2", "164.8", "0.67", "14", "true", "Hydrogen, Helium, Methane" },
           // {"Pluto", "0.00218", "0.1868", "248", "6.39", "5", "false",  "Nitrogen, Methane, Carbon Monoxide" },
           // {"Eris", "0.00277", "0.182", "558.04", "1.08", "1", "false", "Nitrogen, Methane, Carbon Monoxide?" }
        };
    }
}