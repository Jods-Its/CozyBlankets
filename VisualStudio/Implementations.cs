using CozyBlankets;
using MelonLoader;

namespace ModNamespace;
internal sealed class ModClassInheritingFromMelonMod : MelonMod
{
	public override void OnInitializeMelon()
	{
        MelonLoader.MelonLogger.Msg("Bedrolling...");
        MelonLoader.MelonLogger.Msg("Finding cozyness...");
        MelonLoader.MelonLogger.Msg("Sewing blankets...");
        MelonLoader.MelonLogger.Msg("CozyBlankets Loaded!");
        Settings.instance.AddToModSettings("Cozy Blankets");
    }
}
