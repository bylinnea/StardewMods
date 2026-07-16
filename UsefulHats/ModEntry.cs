using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Objects;
using StardewValley.Buffs;

namespace UsefulHats
{
    public class ModEntry : Mod
    {
        private const SButton LogHatKey = SButton.F5;

        private const string HatBuffId = "byLinnea.UsefulHats_HatBuff";

                private const string BlueRibbonId = "BlueRibbon";

        public override void Entry(IModHelper helper)
        {
            this.Monitor.Log("Useful Hats loaded!", LogLevel.Debug);

            helper.Events.Input.ButtonPressed += this.OnButtonPressed;

            helper.Events.GameLoop.UpdateTicked += this.OnUpdateTicked;
        }

        private void OnUpdateTicked(object? sender, UpdateTickedEventArgs e)
        {
            if (!Context.IsWorldReady)
                return;

            if (!e.IsMultipleOf(15))
                return;

            string? wornHatId = Game1.player.hat.Value?.ItemId;
            bool shouldHaveBuff = wornHatId == BlueRibbonId;
            bool hasBuff = Game1.player.hasBuff(HatBuffId);
            if (shouldHaveBuff && !hasBuff)
            {
                Buff buff = new Buff(
                    id: HatBuffId,
                    displayName: "Blue Ribbon",
                    duration: Buff.ENDLESS,
                    effects: new BuffEffects
                    {
                        FishingLevel = { 1 }
                    });

                Game1.player.applyBuff(buff);
                this.Monitor.Log("Applied Fishing Blue Ribbon (+1 Fishing).", LogLevel.Debug);
            }
            else if (!shouldHaveBuff && hasBuff)
            {
                Game1.player.buffs.Remove(HatBuffId);
                this.Monitor.Log("Removed Blue Ribbon buff.", LogLevel.Debug);
            }
        }
        private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
        {
            if (e.Button != LogHatKey)
                return;

            if (!Context.IsWorldReady)
                return;

            Hat? hat = Game1.player.hat.Value;
            if (hat is null)
            {
                this.Monitor.Log("No hat is currently worn.", LogLevel.Info);
                return;
            }

            this.Monitor.Log(
                $"Worn hat: {hat.DisplayName} " +
                $"| ItemId={hat.ItemId} " +
                $"| QualifiedItemId={hat.QualifiedItemId}",
                LogLevel.Info);
        }
    }
}
