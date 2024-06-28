using CozyBlankets;
using MelonLoader;

namespace ModNamespace;
internal sealed class ModClassInheritingFromMelonMod : MelonMod
{
	public override void OnInitializeMelon()
	{
        MelonLoader.MelonLogger.Msg(System.ConsoleColor.Yellow, "Bedrolling...");
        MelonLoader.MelonLogger.Msg(System.ConsoleColor.Yellow, "Finding cozyness...");
        MelonLoader.MelonLogger.Msg(System.ConsoleColor.Yellow, "Sewing blankets...");
        MelonLoader.MelonLogger.Msg(System.ConsoleColor.Green, "CozyBlankets v1.4.2 Loaded!");
        Settings.instance.AddToModSettings("Cozy Blankets");
    }
}
