using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(BuildInfo.ModName)]
[assembly: AssemblyCopyright($"Created by ModAuthor")]

[assembly: AssemblyVersion(BuildInfo.ModVersion)]
[assembly: AssemblyFileVersion(BuildInfo.ModVersion)]
[assembly: MelonInfo(typeof(ModNamespace.ModClassInheritingFromMelonMod), BuildInfo.ModName, BuildInfo.ModVersion, BuildInfo.ModAuthor)]

[assembly: MelonGame("Hinterland", "TheLongDark")]
internal static class BuildInfo
{
	internal const string ModName = "CozyBlankets";
	internal const string ModAuthor = "ds5678, Jods-Its";
	internal const string ModVersion = "1.4.2";
}