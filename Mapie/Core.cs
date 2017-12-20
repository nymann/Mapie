using System;
using PoeHUD.Models.Enums;
using PoeHUD.Plugins;
using PoeHUD.Poe.Components;
using SharpDX;
using SharpDX.Direct3D9;

namespace Mapie
{
    public class Core : BaseSettingsPlugin<Settings>
    {
        public Core()
        {
            PluginName = "Mapie";
        }

        public override void Render()
        {

            if (!GameController.Game.IngameState.IngameUi.InventoryPanel.IsVisible)
            {
                return;
            }

            var inventory =
                GameController.Game.IngameState.IngameUi.InventoryPanel[
                    InventoryIndex.PlayerInventory];

            var inventoryItems = inventory.VisibleInventoryItems;

            foreach (var item in inventoryItems)
            {
                var mods = item.Item.GetComponent<Mods>().ItemMods;

                foreach (var mod in mods)
                {
                    var modName = mod.Name.ToLower();

                    if (Settings.ElementalReflecNode.Value && modName.Contains("reflect") && modName.Contains("elemental"))
                    {
                        Graphics.DrawFrame(item.GetClientRect(), 3, Color.Red);
                        Graphics.DrawText("E-R", 25, item.GetClientRect().Center, Color.Red, FontDrawFlags.Center);
                    }

                    if (Settings.PhysicalReflecNode.Value && modName.Contains("reflect") && modName.Contains("physical"))
                    {
                        Graphics.DrawFrame(item.GetClientRect(), 3, Color.Brown);
                        Graphics.DrawText("P-R", 25, item.GetClientRect().Center, Color.Brown, FontDrawFlags.Center);
                    }

                    if (Settings.TemporalChainsNode.Value && modName.Contains("temporal"))
                    {
                        Graphics.DrawFrame(item.GetClientRect(), 3, Color.Yellow);
                        Graphics.DrawText("T-C", 25, item.GetClientRect().Center, Color.Yellow, FontDrawFlags.Center);
                    }
                }
            }

        }

    }
}
