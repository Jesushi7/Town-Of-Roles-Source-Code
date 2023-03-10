using HarmonyLib;
using TownOfUs.Roles;
using UnityEngine;
using TownOfUs.NeutralRoles.VultureMod;

namespace TownOfUs.ImpostorRoles.VultureMod
{
    [HarmonyPatch(typeof(HudManager), nameof(HudManager.Update))]
    public class PlayerControlUpdate
    {
        public static void Postfix(HudManager __instance)
        {
            if (PlayerControl.AllPlayerControls.Count <= 1) return;
            if (PlayerControl.LocalPlayer == null) return;
            if (PlayerControl.LocalPlayer.Data == null) return;
            if (!PlayerControl.LocalPlayer.Is(RoleEnum.Vulture)) return;

            var role = Role.GetRole<Vulture>(PlayerControl.LocalPlayer);
            if (role.EatButton == null)
            {
                role.EatButton = Object.Instantiate(__instance.KillButton, __instance.KillButton.transform.parent);
                role.EatButton.graphic.enabled = true;
                role.EatButton.GetComponent<AspectPosition>().DistanceFromEdge = TownOfUs.ButtonPosition;
                role.EatButton.gameObject.SetActive(false);
            }

            role.EatButton.GetComponent<AspectPosition>().Update();
            role.EatButton.gameObject.SetActive(!PlayerControl.LocalPlayer.Data.IsDead && !MeetingHud.Instance);
            role.EatButton.graphic.sprite = TownOfUs.VultureEat;


            var data = PlayerControl.LocalPlayer.Data;
            var isDead = data.IsDead;
            var truePosition = PlayerControl.LocalPlayer.GetTruePosition();
            var maxDistance = GameOptionsData.KillDistances[PlayerControl.GameOptions.KillDistance];
            var flag = (PlayerControl.GameOptions.GhostsDoTasks || !data.IsDead) &&
                       (!AmongUsClient.Instance || !AmongUsClient.Instance.IsGameOver) &&
                       PlayerControl.LocalPlayer.CanMove;
            var allocs = Physics2D.OverlapCircleAll(truePosition, maxDistance,
                LayerMask.GetMask(new[] { "Players", "Ghost" }));
            var killButton = role.EatButton;
            DeadBody closestBody = null;
            var closestDistance = float.MaxValue;

            foreach (var collider2D in allocs)
            {
                if (!flag || isDead || collider2D.tag != "DeadBody") continue;
                var component = collider2D.GetComponent<DeadBody>();
                if (!(Vector2.Distance(truePosition, component.TruePosition) <=
                      maxDistance)) continue;

                var distance = Vector2.Distance(truePosition, component.TruePosition);
                if (!(distance < closestDistance)) continue;
                closestBody = component;
                closestDistance = distance;
            }


            KillButtonTarget.SetTarget(killButton, closestBody, role);
            role.EatButton.SetCoolDown(PlayerControl.LocalPlayer.killTimer, PlayerControl.GameOptions.KillCooldown);
        }
    }
}