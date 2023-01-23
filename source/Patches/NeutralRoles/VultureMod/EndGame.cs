using HarmonyLib;
using Hazel;
using TownOfUs.Roles;

namespace TownOfUs.NeutralRoles.VultureMod
{
    [HarmonyPatch(typeof(ShipStatus), nameof(ShipStatus.RpcEndGame))]
    public class EndGame
    {
        public static bool Prefix(ShipStatus __instance, [HarmonyArgument(0)] GameOverReason reason)
        {
            foreach (Vulture vult in Role.GetRoles(RoleEnum.Vulture))
            {
                if (vult.EatNeed == 0)
                {
                    vult.Loses();
                    var writer = AmongUsClient.Instance.StartRpcImmediately(PlayerControl.LocalPlayer.NetId, (byte) CustomRPC.VultureWin, SendOption.Reliable, -1);
                    writer.Write((byte)CustomRPC.VultureLose);
                    writer.Write(vult.Player.PlayerId);
                    AmongUsClient.Instance.FinishRpcImmediately(writer);
                }
            }

            return true;
        }
    }
}