namespace UsefulHats
{
    public class ModConfig
    {
        public Dictionary<string, HatStats> Hats { get; set; } = new()
        {
            ["BlueRibbon"] = new HatStats { Fishing = 1 }
        };
    }

    public class HatStats
    {
        public int Farming { get; set; }
        public int Fishing { get; set; }
        public int Mining { get; set; }
        public int Foraging { get; set; }
        public int Luck { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int MaxStamina { get; set; }
        public int MagneticRadius { get; set; }
    }
}