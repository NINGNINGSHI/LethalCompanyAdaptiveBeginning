using GameNetcodeStuff;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChangeMaskAppearance.Patches
{
    [HarmonyPatch(typeof(PlayerControllerB))]
    internal class PlayerControllerBPatch
    {
        [HarmonyPatch("Update")]
        [HarmonyPostfix]
        public static void InfiniteSprintPatch(ref float ___sprintMeter)
        {
            ___sprintMeter = 1f;
        }
    }
}
