namespace Planets
{
    public class Planet
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public double EquitorialDiameter { get; set; }
        public double Mass { get; set; }
        public double OrbitalPeriod { get; set; }
        public double RotationPeriod { get; set; } //days
        public double ConfirmedMoons { get; set; }
        public bool HasRings { get; set; }
        public string Atmosphere { get; set; }


        public int Id { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}