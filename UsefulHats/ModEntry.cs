using StardewModdingAPI;

namespace UsefulHats
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("Useful Hats loaded!", LogLevel.Debug);
        }
    }
}
