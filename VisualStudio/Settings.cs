using Il2Cpp;
using ModSettings;


namespace CozyBlankets
{
    internal class Settings : JsonModSettings
    {
        public static Settings instance = new Settings();

        [Section("Patchwork Bedroll")]

        [Name("Warmth Bonus Maximum")]
        [Description("The warmth bonus at 100% bedroll condition. Default is 5 celsius. Setting takes effect on game reload.")]
        [Slider(0f, 10f, 101)]
        public float bedrollWarmth = 5f;

        [Section("Blankets")]

        [Name("Warmth Bonus (Patchwork Blanket)")]
        [Description("The additional warmth bonus per blanket carried. Recommended is 1 celsius.")]
        [Slider(0f, 5f, 51)]
        public float blanketWarmth = 1f;

        [Name("Max Bonus (Patchwork Blanket)")]
        [Description("The maximum additional warmth a player can have. Recommended is 5 celsius.")]
        [Slider(0f, 20f, 201)]
        public float blanketMaxBonus = 5f;

        [Name("Warmth Bonus (Old Blanket)")]
        [Description("The additional warmth bonus per blanket carried. Recommended is 2 celsius.")]
        [Slider(0f, 5f, 51)]
        public float blanketOldWarmth = 2f;

        [Name("Max Bonus (Old Blanket)")]
        [Description("The maximum additional warmth a player can have. Recommended is 10 celsius.")]
        [Slider(0f, 20f, 201)]
        public float blanketOldMaxBonus = 10f;
    }
}

