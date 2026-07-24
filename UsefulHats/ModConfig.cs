namespace UsefulHats
{
    public class ModConfig
    {
        public Dictionary<string, HatStats> Hats { get; set; } = new()
        {

            // Fishing hats
            ["5"] = new HatStats { Fishing = 1 },
            ["17"] = new HatStats { Fishing = 1, MaxStamina = 20 },
            ["24"] = new HatStats { Fishing = 2, Luck = 1 },
            ["28"] = new HatStats { Fishing = 1 }, 
            ["30"] = new HatStats { MaxStamina = 40 },
            ["55"] = new HatStats { Fishing = 2 },
            ["56"] = new HatStats { Fishing = 1, Luck = 1 },
            ["78"] = new HatStats { Fishing = 2, MaxStamina = 60 },
            ["BucketHat"] = new HatStats { MaxStamina = 40 },
            ["SquidHat"] = new HatStats { Fishing = 1, MaxStamina = 40 },

            // Farming hats
            ["3"] = new HatStats { Farming = 1, Luck = 2 },
            ["4"] = new HatStats { Farming = 2 },
            ["10"] = new HatStats { Farming = 1, Foraging = 1 },
            ["16"] = new HatStats { Foraging = 1 },
            ["18"] = new HatStats { Farming = 1 },
            ["23"] = new HatStats { Farming = 1, Foraging = 1, MaxStamina = 60 },
            ["29"] = new HatStats { Foraging = 1 },
            ["33"] = new HatStats { Farming = 2 },
            ["34"] = new HatStats { Farming = 2 }, 
            ["JunimoHat"] = new HatStats { Farming = 2, Luck = 1, Speed = 1},
            ["BlueRibbon"] = new HatStats { Farming = 1, Foraging = 1 },

            // Mining & combat hats
            ["8"] = new HatStats { Attack = 1, Immunity = 1 },
            ["27"] = new HatStats { Mining = 1, Defense = 1 },
            ["46"] = new HatStats { Defense = 1, Mining = 1 },
            ["50"] = new HatStats { Attack = 2, Defense = 1 },
            ["51"] = new HatStats { Attack = 1, Defense = 1 },
            ["60"] = new HatStats { Immunity = 3 },
            ["75"] = new HatStats { Defense = 2, MagneticRadius = 16 },
            ["84"] = new HatStats { Mining = 1, Immunity = 1 },
            ["87"] = new HatStats { MagneticRadius = 32 },
            ["89"] = new HatStats { Mining = 1 },
            ["91"] = new HatStats { Attack = 2, Speed = 1, Immunity = 1 },
            ["92"] = new HatStats { Attack = 2 },
            ["MummyMask"] = new HatStats { Immunity = 2 },
            ["SpaceHelmet"] = new HatStats { Immunity = 2, Defense = 1 },
            ["InfinityCrown"] = new HatStats { Speed = 1, Attack = 2, Luck = 1 },

            // Luck & money hats
            ["1"] = new HatStats { Luck = 1, MaxStamina = 20 },
            ["2"] = new HatStats { Speed = 1, Luck = 1 },
            ["19"] = new HatStats { MaxStamina = 20 },
            ["20"] = new HatStats { Farming = 1, MagneticRadius = 16 },
            ["21"] = new HatStats { Luck = 1 },
            ["66"] = new HatStats { Luck = 2, MagneticRadius = 16 },
            ["73"] = new HatStats { Mining = 1, Farming = 1, Foraging = 1 },
            ["74"] = new HatStats { Immunity = 3 },
            ["82"] = new HatStats { Luck = 2, Speed = 1, Immunity = 1 },
            ["LeprechuanHat"] = new HatStats { Luck = 3 },
            ["MysteryHat"] = new HatStats { Luck = 2 },

            // Foraging & nature hats
            ["6"] = new HatStats { Foraging = 1 },
            ["15"] = new HatStats { MaxStamina = 40 },
            ["39"] = new HatStats { MagneticRadius = 32 },
            ["40"] = new HatStats { Luck = 2, Speed = 2, Foraging = 2 },
            ["42"] = new HatStats { Foraging = 2, Luck = 1 },
            ["44"] = new HatStats { MaxStamina = 20, Defense = 1 },
            ["90"] = new HatStats { Foraging = 1 },
            ["RaccoonHat"] = new HatStats { Foraging = 2, MagneticRadius = 16 },
            ["WhiteBow"] = new HatStats { Foraging = 2 },

            // Social & friendship hats
            ["11"] = new HatStats { Defense = 2 },
            ["14"] = new HatStats { Luck = 1 },
            ["22"] = new HatStats { MaxStamina = 20 },
            ["25"] = new HatStats { MaxStamina = 20, MagneticRadius = 16 },
            ["26"] = new HatStats { MaxStamina = 20 },
            ["31"] = new HatStats { MagneticRadius = 32 },
            ["32"] = new HatStats { Speed = 1, MaxStamina = 20 },
            ["41"] = new HatStats { Immunity = 2, MagneticRadius = 16 },
            ["69"] = new HatStats { MaxStamina = 20 },
            ["GovernorsHat"] = new HatStats { MaxStamina = 20, MagneticRadius = 16 },

            // Cooking hats
            ["7"] = new HatStats { MaxStamina = 40 },
            ["12"] = new HatStats { MaxStamina = 20 },
            ["35"] = new HatStats { Luck = 2, MaxStamina = 20 },
            ["61"] = new HatStats { Luck = 1, MaxStamina = 40 },

            // Cowboys & desert
            ["0"] = new HatStats { Luck = 1, Foraging = 2 },
            ["37"] = new HatStats { Luck = 1, Fishing = 2 },
            ["38"] = new HatStats { Luck = 1, Mining = 2 },
            ["81"] = new HatStats { Luck = 1, Farming = 2 },
            ["83"] = new HatStats { Luck = 1, Attack = 2},

            // Pirates
            ["62"] = new HatStats { Luck = 1 },
            ["76"] = new HatStats { Luck = 2, Fishing = 1 },
            ["85"] = new HatStats { Fishing = 1 },
            ["TricornHat"] = new HatStats { Luck = 1 },

            // Pan hats
            ["71"] = new HatStats { MagneticRadius = 16 },
            ["SteelPanHat"] = new HatStats { MagneticRadius = 16 },
            ["GoldPanHat"] = new HatStats { MagneticRadius = 32 },
            ["IridiumPanHat"] = new HatStats { MagneticRadius = 48 },

            // Prestige
            ["9"] = new HatStats { Farming = 1, Mining = 1, Foraging = 1 },
            ["64"] = new HatStats { Immunity = 3, Attack = 1, Defense = 1 },
            ["86"] = new HatStats { Immunity = 3 },
            ["93"] = new HatStats { Speed = 1, Farming = 1, Mining = 1, Foraging = 1, Fishing = 1 },

            // Misc tier 2–3
            ["43"] = new HatStats { Attack = 1, Defense = 1 },
            ["48"] = new HatStats { MaxStamina = 40 },
            ["65"] = new HatStats { Immunity = 2 },
            ["67"] = new HatStats { Luck = 2 },
            ["70"] = new HatStats { Immunity = 1, MagneticRadius = 16 },
            ["72"] = new HatStats { Immunity = 1, Foraging = 1 },
            ["77"] = new HatStats { Luck = 1, MaxStamina = 20 },
            ["79"] = new HatStats { MaxStamina = 40 },
            ["80"] = new HatStats { Luck = 1, MagneticRadius = 16 },
            ["RedFez"] = new HatStats { Luck = 2 },
            ["LaurelWreathCrown"] = new HatStats { Foraging = 2 },
            ["GilsHat"] = new HatStats { Mining = 2 },
            ["PageboyCap"] = new HatStats { Speed = 1, Luck = 1 },

            // Tier-1 fillers
            ["13"] = new HatStats { MaxStamina = 20 },
            ["45"] = new HatStats { MaxStamina = 20 },
            ["47"] = new HatStats { Luck = 1 },
            ["49"] = new HatStats { Attack = 1 },
            ["52"] = new HatStats { Foraging = 1 },
            ["53"] = new HatStats { MaxStamina = 20 },
            ["54"] = new HatStats { MaxStamina = 20 },
            ["57"] = new HatStats { Mining = 1 },
            ["58"] = new HatStats { Fishing = 1 },
            ["59"] = new HatStats { Farming = 1 },
            ["63"] = new HatStats { Farming = 1},
            ["68"] = new HatStats { Defense = 1 },
            ["88"] = new HatStats { Defense = 1 },
            ["PaperHat"] = new HatStats { Fishing = 1 },
            ["JesterHat"] = new HatStats { Immunity = 1 },
            ["SportsCap"] = new HatStats { MaxStamina = 20 },
            ["AbigailsBow"] = new HatStats { Luck = 1 },
            ["JojaCap"] = new HatStats { MagneticRadius = 16 },
            ["BlueBow"] = new HatStats { Foraging = 1 },
            ["DarkVelvetBow"] = new HatStats { Immunity = 1 },
            ["DarkBallcap"] = new HatStats { Attack = 1 }
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
        public int Immunity { get; set; }

        public IEnumerable<(string Name, int Value)> GetStats()
        {
            yield return ("Farming", this.Farming);
            yield return ("Fishing", this.Fishing);
            yield return ("Mining", this.Mining);
            yield return ("Foraging", this.Foraging);
            yield return ("Luck", this.Luck);
            yield return ("Attack", this.Attack);
            yield return ("Defense", this.Defense);
            yield return ("Immunity", this.Immunity);
            yield return ("Speed", this.Speed);
            yield return ("Max Energy", this.MaxStamina);
            yield return ("Magnetism", this.MagneticRadius);
        }
    }
    
}