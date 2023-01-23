using System;
using System.Collections.Generic;
using System.Linq;
using Hazel;

namespace TownOfUs.Roles
{
    public class Pyromaniac : Role
    {
        private KillButton _igniteButton;
        public bool PyromaniacWins;
        public PlayerControl ClosestPlayer;
        public List<byte> DousedPlayers = new List<byte>();
        public bool IgniteUsed;
        public DateTime LastDoused;


        public Pyromaniac(PlayerControl player) : base(player)
        {
            Name = "Pyromaniac";
            ImpostorText = () => "Spray gasoline on the others";
            TaskText = () => "Spills gasoline on the others\nFake Tasks:";
            Color = Patches.Colors.Pyromaniac;
            LastDoused = DateTime.UtcNow;
            RoleType = RoleEnum.Pyromaniac;
            AddToRoleHistory(RoleType);
            Faction = Faction.Neutral;
        }

        public KillButton IgniteButton
        {
            get => _igniteButton;
            set
            {
                _igniteButton = value;
                ExtraButtons.Clear();
                ExtraButtons.Add(value);
            }
        }

        internal override bool EABBNOODFGL(ShipStatus __instance)
        {
            if (PlayerControl.AllPlayerControls.ToArray().Count(x => !x.Data.IsDead && !x.Data.Disconnected) == 0)
            {
                var writer = AmongUsClient.Instance.StartRpcImmediately(
                    PlayerControl.LocalPlayer.NetId,
                    (byte) CustomRPC.PyromaniacWin,
                    SendOption.Reliable,
                    -1
                );
                writer.Write(Player.PlayerId);
                Wins();
                AmongUsClient.Instance.FinishRpcImmediately(writer);
                Utils.EndGame();
                return false;
            }

            if (IgniteUsed || Player.Data.IsDead) return true;

            return !CustomGameOptions.PyromaniacEndGame;
        }


        public void Wins()
        {
            //System.Console.WriteLine("Reached Here - Glitch Edition");
            PyromaniacWins = true;
        }

        public void Loses()
        {
            LostByRPC = true;
        }

        public bool CheckEveryoneDoused()
        {
            var arsoId = Player.PlayerId;
            foreach (var player in PlayerControl.AllPlayerControls)
            {
                if (
                    player.PlayerId == arsoId ||
                    player.Data.IsDead ||
                    player.Data.Disconnected
                ) continue;
                if (!DousedPlayers.Contains(player.PlayerId)) return false;
            }

            return true;
        }

        protected override void IntroPrefix(IntroCutscene._ShowTeam_d__21 __instance)
        {
            var Pyromaniacteam = new Il2CppSystem.Collections.Generic.List<PlayerControl>();
            Pyromaniacteam.Add(PlayerControl.LocalPlayer);
            __instance.teamToShow = Pyromaniacteam;
        }

        public float DouseTimer()
        {
            var utcNow = DateTime.UtcNow;
            var timeSpan = utcNow - LastDoused;
            var num = CustomGameOptions.GasolineCd * 1000f;
            var flag2 = num - (float) timeSpan.TotalMilliseconds < 0f;
            if (flag2) return 0;
            return (num - (float) timeSpan.TotalMilliseconds) / 1000f;
        }
    }
}
