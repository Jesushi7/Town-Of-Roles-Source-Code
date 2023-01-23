using System;
using HarmonyLib;
using TownOfUs.Roles;
using Object = UnityEngine.Object;

namespace TownOfUs.NeutralRoles.PyromaniacMod
{
    [HarmonyPatch(typeof(Object), nameof(Object.Destroy), typeof(Object))]
    public static class HUDClose
    {
        public static void Postfix(Object obj)
        {
            if (ExileController.Instance == null || obj != ExileController.Instance.gameObject) return;
            foreach (var role in Role.GetRoles(RoleEnum.Pyromaniac))
            {
                var Pyromaniac = (Pyromaniac) role;
                Pyromaniac.LastDoused = DateTime.UtcNow;
            }
        }
    }
}