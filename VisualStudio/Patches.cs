using Il2Cpp;
using HarmonyLib;

namespace CozyBlankets
{
    internal static class Patches
    {
        private const string BLANKET_NAME = "GEAR_MakeshiftBlanket";
        private const string BEDROLL_NAME = "GEAR_MakeshiftBedroll";
        private static string[] BLANKET_OLD_NAMES = {"GEAR_OldBlanket1", "GEAR_OldBlanket2" };

        [HarmonyPatch(typeof(GearItem), "Awake")]
        private static class ChangeItems
        {
            internal static void Postfix(GearItem __instance)
            {
                if (__instance.name == BEDROLL_NAME)
                {
                    __instance.m_Bed.m_WarmthBonusCelsius = Settings.instance.bedrollWarmth;
                }
            }
        }

        [HarmonyPatch(typeof(Bed), "GetWarmthBonusCelsius")]
        private static class PatchworkBlanketWarmthBonus
        {
            internal static void Postfix(ref float __result)
            {
                if (GameManager.GetInventoryComponent().GearInInventory(BLANKET_NAME, 1))
                {
                    __result += Math.Min(Settings.instance.blanketMaxBonus, Settings.instance.blanketWarmth * GameManager.GetInventoryComponent().GearInInventory(BLANKET_NAME, 1).m_StackableItem.m_Units);
                }
            }
        }

        [HarmonyPatch(typeof(Bed), "GetWarmthBonusCelsius")]
        private static class OldBlanketWarmthBonus
        {
            internal static void Postfix(ref float __result)
            {
                if (GameManager.GetInventoryComponent().GearInInventory(BLANKET_OLD_NAMES[0], 1))
                {
                    __result += Math.Min(Settings.instance.blanketOldMaxBonus, Settings.instance.blanketOldWarmth * GameManager.GetInventoryComponent().GearInInventory(BLANKET_OLD_NAMES[0], 1).m_StackableItem.m_Units);
                }
                if (GameManager.GetInventoryComponent().GearInInventory(BLANKET_OLD_NAMES[1], 1))
                {
                    __result += Math.Min(Settings.instance.blanketOldMaxBonus, Settings.instance.blanketOldWarmth * GameManager.GetInventoryComponent().GearInInventory(BLANKET_OLD_NAMES[1], 1).m_StackableItem.m_Units);
                }
            }
        }
    }
}
