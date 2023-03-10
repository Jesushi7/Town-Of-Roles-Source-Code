using System;
using HarmonyLib;
using TownOfUs.Roles;
using Object = UnityEngine.Object;

namespace TownOfUs.CrewmateRoles.MysticMod
{
    [HarmonyPatch(typeof(Object), nameof(Object.Destroy), typeof(Object))]
    public static class HUDClose
    {
        public static void Postfix(Object obj)
        {
            if (ExileController.Instance == null || obj != ExileController.Instance.gameObject) return;
            foreach (var role in Role.GetRoles(RoleEnum.Detective))
            {
                var detective = (Mystic) role;
                detective.LastExamined = DateTime.UtcNow;
                detective.LastExamined = detective.LastExamined.AddSeconds(CustomGameOptions.InitialExamineCd - CustomGameOptions.ExamineCd);
            }
        }
    }
}