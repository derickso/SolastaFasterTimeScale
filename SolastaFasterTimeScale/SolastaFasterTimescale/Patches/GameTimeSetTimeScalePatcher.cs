using HarmonyLib;
using UnityEngine;

namespace SolastaFasterTimeScale.Patches
{
    internal static class GameTimeSetTimeScalePatcher
    {
        [HarmonyPatch(typeof(GameTime), "SetTimeScale")]
        static class GameTime_SetTimeScale_Patch
        {
            static bool Prefix(ref float ___timeScale, ref bool ___fasterTimeMode)
            {
                Time.timeScale = ___timeScale * (___fasterTimeMode ? Viewers.ModSettingsViewer.CustomTimeScale : 1f);

                return false;
            }
        }
    }
}