using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
using StardewValley.Objects;
using StardewValley.Buffs;

namespace UsefulHats
{
    public class ModEntry : Mod
    {
        private ModConfig Config = null!;
        private const SButton LogHatKey = SButton.F5;

        private const string HatBuffId = "byLinnea.UsefulHats_HatBuff";

        private string? lastAppliedHatId;

        public override void Entry(IModHelper helper)
        {
            this.Config = this.Helper.ReadConfig<ModConfig>();

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

            Hat? wornHat = Game1.player.hat.Value;
            string? wornHatId = wornHat?.ItemId;

            HatStats? stats = null;
            if (wornHatId != null)
                this.Config.Hats.TryGetValue(wornHatId, out stats);

            bool hasBuff = Game1.player.hasBuff(HatBuffId);

            if (stats is null)
            {
                if (hasBuff)
                {
                    this.Monitor.Log($"Removed {lastAppliedHatId}.", LogLevel.Debug);
                    Game1.player.buffs.Remove(HatBuffId);
                    lastAppliedHatId = null;
                }
            }
            else if (!hasBuff || lastAppliedHatId != wornHatId)
            {
                Buff buff = new Buff(
                    id: HatBuffId,
                    displayName: wornHat!.DisplayName,
                    duration: Buff.ENDLESS,
                    effects: new BuffEffects
                    {
                        FarmingLevel = {stats.Farming},
                        FishingLevel = {stats.Fishing},
                        MiningLevel = {stats.Mining},
                        ForagingLevel = {stats.Foraging},
                        LuckLevel = {stats.Luck},
                        Attack = {stats.Attack},
                        Defense = {stats.Defense},
                        Speed = {stats.Speed},
                        MaxStamina = {stats.MaxStamina},
                        MagneticRadius = {stats.MagneticRadius},
                        Immunity = {stats.Immunity}
                    });
                Game1.player.applyBuff(buff);
                this.Monitor.Log($"Applied {wornHat.DisplayName} buff",LogLevel.Debug);
                lastAppliedHatId = wornHatId;
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
