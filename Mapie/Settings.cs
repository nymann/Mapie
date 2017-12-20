using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;

namespace Mapie
{
    public class Settings : SettingsBase
    {
        public Settings()
        {
            Enable = false;

            SettingsNode = new EmptyNode();
            ElementalReflecNode = true;
            PhysicalReflecNode = true;
            TemporalChainsNode = true;
        }

        [Menu("Settings", 7777)]
        public EmptyNode SettingsNode { get; set; }

        [Menu("Elemental Reflect", "Enable this, if you want to be warned when a map has the mod: \"Elemental Reflect\".", 7770, 7777)]
        public ToggleNode ElementalReflecNode { get; set; }

        [Menu("Physical Reflect", "Enable this, if you want to be warned when a map has the mod: \"Physical Reflect\".", 8880, 7777)]
        public ToggleNode PhysicalReflecNode { get; set; }

        [Menu("Temporal Chains", "Enable this, if you want to be warned when a map has the mod: \"Temporal Chains\".", 9990, 7777)]
        public ToggleNode TemporalChainsNode { get; set; }
    }
}
