using System;

namespace TownOfUs.CustomOption
{
    public class Generate
    {
        public static CustomHeaderOption CrewInvestigativeRoles;
        public static CustomNumberOption HaunterOn;
        public static CustomNumberOption InvestigatorOn;
        public static CustomNumberOption MysticOn;
        public static CustomNumberOption SeerOn;
        public static CustomNumberOption SnitchOn;
        public static CustomNumberOption SpyOn;
        public static CustomNumberOption TrackerOn;
        public static CustomNumberOption TrapperOn;

        public static CustomHeaderOption CrewProtectiveRoles;
        public static CustomNumberOption AltruistOn;
        public static CustomNumberOption MedicOn;

        public static CustomHeaderOption CrewKillingRoles;
        public static CustomNumberOption SheriffOn;
        public static CustomNumberOption VeteranOn;
        public static CustomNumberOption VigilanteOn;

        public static CustomHeaderOption CrewSupportRoles;
        public static CustomNumberOption EngineerOn;
        public static CustomNumberOption MediumOn;

        public static CustomHeaderOption CrewChaosRoles;
        public static CustomNumberOption MayorOn;
        public static CustomNumberOption SwapperOn;
        public static CustomNumberOption TimeLordOn;
        public static CustomNumberOption TransporterOn;

        public static CustomHeaderOption NeutralBenignRoles;
        public static CustomNumberOption AmnesiacOn;
        public static CustomNumberOption GuardianAngelOn;
        public static CustomNumberOption SurvivorOn;

        public static CustomHeaderOption NeutralEvilRoles;
        public static CustomNumberOption ExecutionerOn;
        public static CustomNumberOption JesterOn;
        public static CustomNumberOption PhantomOn;
        public static CustomNumberOption VultureOn;
        public static CustomNumberOption PyromaniacOn;

        public static CustomHeaderOption NeutralKillingRoles;
        public static CustomNumberOption ArsonistOn;
        public static CustomNumberOption PlaguebearerOn;
        public static CustomNumberOption GlitchOn;
        public static CustomNumberOption WerewolfOn;
        public static CustomNumberOption JuggernautOn;

        public static CustomHeaderOption ImpostorConcealingRoles;
        public static CustomNumberOption EscapistOn;
        public static CustomNumberOption MorphlingOn;
        public static CustomNumberOption SwooperOn;
        public static CustomNumberOption GrenadierOn;

        public static CustomHeaderOption ImpostorKillingRoles;
        public static CustomNumberOption PoisonerOn;
        public static CustomNumberOption TraitorOn;

        public static CustomHeaderOption ImpostorSupportRoles;
        public static CustomNumberOption BlackmailerOn;
        public static CustomNumberOption JanitorOn;
        public static CustomNumberOption MinerOn;
        public static CustomNumberOption UndertakerOn;

        public static CustomHeaderOption CrewmateModifiers;
        public static CustomNumberOption BaitOn;
        public static CustomNumberOption BlindOn;
        public static CustomNumberOption DiseasedOn;
        public static CustomNumberOption MultitaskerOn;
        public static CustomNumberOption TorchOn;

        public static CustomHeaderOption GlobalModifiers;
        public static CustomNumberOption ButtonBarryOn;
        public static CustomNumberOption FlashOn;
        public static CustomNumberOption GiantOn;
        public static CustomNumberOption LoversOn;
        public static CustomNumberOption RadarOn;
        public static CustomNumberOption SleuthOn;
        public static CustomNumberOption TiebreakerOn;
        public static CustomNumberOption DrunkOn;

        public static CustomHeaderOption ImpostorModifiers;
        public static CustomNumberOption DisperserOn;
        public static CustomNumberOption DoubleShotOn;
        public static CustomNumberOption UnderdogOn;

        public static CustomHeaderOption MapSettings;
        public static CustomToggleOption RandomMapEnabled;
        public static CustomNumberOption RandomMapSkeld;
        public static CustomNumberOption RandomMapMira;
        public static CustomNumberOption RandomMapPolus;
        public static CustomNumberOption RandomMapAirship;
        public static CustomNumberOption RandomMapSubmerged;
        public static CustomToggleOption AutoAdjustSettings;
        public static CustomToggleOption SmallMapHalfVision;
        public static CustomNumberOption SmallMapDecreasedCooldown;
        public static CustomNumberOption LargeMapIncreasedCooldown;
        public static CustomNumberOption SmallMapIncreasedShortTasks;
        public static CustomNumberOption SmallMapIncreasedLongTasks;
        public static CustomNumberOption LargeMapDecreasedShortTasks;
        public static CustomNumberOption LargeMapDecreasedLongTasks;

        public static CustomHeaderOption CustomGameSettings;
        public static CustomToggleOption ColourblindComms;
        public static CustomToggleOption EveryoneVenting;
        public static CustomToggleOption RandomSpawns;
        public static CustomToggleOption DeadSeeRoles;
        public static CustomToggleOption DisableLevels;
        public static CustomToggleOption WhiteNameplates;
        public static CustomNumberOption VanillaGame;
        public static CustomNumberOption InitialCooldowns;
        public static CustomToggleOption ParallelMedScans;
        public static CustomStringOption SkipButtonDisable;

        public static CustomHeaderOption BetterPolusSettings;
        public static CustomToggleOption VentImprovements;
        public static CustomToggleOption SkeldVentImprovements;
        public static CustomToggleOption VitalsLab;
        public static CustomToggleOption ColdTempDeathValley;
        public static CustomToggleOption WifiChartCourseSwap;

        public static CustomHeaderOption GameModeSettings;
        public static CustomStringOption GameMode;

        public static CustomHeaderOption ClassicSettings;
        public static CustomNumberOption MinNeutralNonKillingRoles;
        public static CustomNumberOption MaxNeutralNonKillingRoles;
        public static CustomNumberOption MinNeutralKillingRoles;
        public static CustomNumberOption MaxNeutralKillingRoles;

        public static CustomHeaderOption AllAnySettings;
        public static CustomToggleOption RandomNumberImps;

        public static CustomHeaderOption KillingOnlySettings;
        public static CustomNumberOption NeutralRoles;
        public static CustomNumberOption VeteranCount;
        public static CustomNumberOption VigilanteCount;
        public static CustomToggleOption AddArsonist;
        public static CustomToggleOption AddPlaguebearer;

        public static CustomHeaderOption TaskTrackingSettings;
        public static CustomToggleOption SeeTasksDuringRound;
        public static CustomToggleOption SeeTasksDuringMeeting;
        public static CustomToggleOption SeeTasksWhenDead;

        public static CustomHeaderOption Mayor;
        public static CustomNumberOption MayorVoteBank;
        public static CustomToggleOption MayorAnonymous;

        public static CustomHeaderOption Sheriff;
        public static CustomToggleOption SheriffKillOther;
        public static CustomToggleOption SheriffKillsJester;
        public static CustomToggleOption SheriffKillsGlitch;
        public static CustomToggleOption SheriffKillsExecutioner;
        public static CustomToggleOption SheriffKillsArsonist;
        public static CustomToggleOption SheriffKillsPyromaniac;
        public static CustomToggleOption SheriffKillsWerewolf;
        public static CustomToggleOption SheriffKillsPlaguebearer;
        public static CustomNumberOption SheriffKillCd;
        public static CustomToggleOption SheriffBodyReport;


        public static CustomHeaderOption Engineer;
        public static CustomStringOption EngineerPer;

        public static CustomHeaderOption Investigator;
        public static CustomNumberOption FootprintSize;
        public static CustomNumberOption FootprintInterval;
        public static CustomNumberOption FootprintDuration;
        public static CustomToggleOption AnonymousFootPrint;
        public static CustomToggleOption VentFootprintVisible;

        public static CustomHeaderOption TimeLord;
        public static CustomToggleOption RewindRevive;
        public static CustomNumberOption RewindDuration;
        public static CustomNumberOption RewindCooldown;
        public static CustomNumberOption RewindMaxUses;
        public static CustomToggleOption TimeLordVitals;

        public static CustomHeaderOption Medic;
        public static CustomStringOption ShowShielded;
        public static CustomStringOption WhoGetsNotification;
        public static CustomToggleOption ShieldBreaks;
        public static CustomToggleOption MedicReportSwitch;
        public static CustomNumberOption MedicReportNameDuration;
        public static CustomNumberOption MedicReportColorDuration;

        public static CustomHeaderOption Seer;
        public static CustomNumberOption SeerCooldown;
        public static CustomToggleOption CrewKillingRed;
        public static CustomToggleOption NeutBenignRed;
        public static CustomToggleOption NeutEvilRed;
        public static CustomToggleOption NeutKillingRed;
        public static CustomToggleOption TraitorColourSwap;

        public static CustomHeaderOption Swapper;
        public static CustomToggleOption SwapperButton;

        public static CustomHeaderOption Transporter;
        public static CustomNumberOption TransportCooldown;
        public static CustomNumberOption TransportMaxUses;
        public static CustomToggleOption TransporterVitals;

        public static CustomHeaderOption Jester;
        public static CustomToggleOption JesterButton;
        public static CustomToggleOption JesterVent;
        public static CustomToggleOption JesterSwitchVents;
        public static CustomToggleOption JesterImpVision;

        public static CustomHeaderOption Vulture;
        public static CustomNumberOption VultureCd;
        public static CustomNumberOption VultureBodies;
        public static CustomToggleOption EatArrows;
        public static CustomNumberOption EatArrowDelay;
        public static CustomToggleOption VultureVent;

        public static CustomHeaderOption Pyromaniac;
        public static CustomNumberOption GasolineCd;
        public static CustomToggleOption PyromaniacEndGame;

        public static CustomHeaderOption TheGlitch;
        public static CustomNumberOption MimicCooldownOption;
        public static CustomNumberOption MimicDurationOption;
        public static CustomNumberOption HackCooldownOption;
        public static CustomNumberOption HackDurationOption;
        public static CustomNumberOption GlitchKillCooldownOption;
        public static CustomStringOption GlitchHackDistanceOption;
        public static CustomToggleOption GlitchVent;

        public static CustomHeaderOption Juggernaut;
        public static CustomToggleOption JuggVent;
        public static CustomNumberOption JuggKillCooldown;
        public static CustomNumberOption JuggKillBonus;

        public static CustomHeaderOption Morphling;
        public static CustomNumberOption MorphlingCooldown;
        public static CustomNumberOption MorphlingDuration;
        public static CustomToggleOption MorphlingVent;

        public static CustomHeaderOption Executioner;
        public static CustomStringOption OnTargetDead;
        public static CustomToggleOption ExecutionerButton;

        public static CustomHeaderOption Phantom;
        public static CustomNumberOption PhantomTasksRemaining;

        public static CustomHeaderOption Snitch;
        public static CustomToggleOption SnitchOnLaunch;
        public static CustomToggleOption SnitchSeesNeutrals;
        public static CustomNumberOption SnitchTasksRemaining;
        public static CustomToggleOption SnitchSeesImpInMeeting;
        public static CustomToggleOption SnitchSeesTraitor;

        public static CustomHeaderOption Altruist;
        public static CustomNumberOption ReviveDuration;
        public static CustomToggleOption AltruistTargetBody;

        public static CustomHeaderOption Miner;
        public static CustomNumberOption MineCooldown;

        public static CustomHeaderOption Swooper;
        public static CustomNumberOption SwoopCooldown;
        public static CustomNumberOption SwoopDuration;
        public static CustomToggleOption SwooperVent;

        public static CustomHeaderOption Arsonist;
        public static CustomNumberOption DouseCooldown;
        public static CustomNumberOption MaxDoused;
        public static CustomToggleOption ArsoImpVision;
        public static CustomToggleOption IgniteCdRemoved;
        public static CustomToggleOption ArsonistVent;

        public static CustomHeaderOption Undertaker;
        public static CustomNumberOption DragCooldown;
        public static CustomToggleOption UndertakerVent;
        public static CustomToggleOption UndertakerVentWithBody;
        public static CustomToggleOption UndertakerIsSlowWhenDragging;

        public static CustomHeaderOption Assassin;
        public static CustomToggleOption ImpostorSeeRoles;
        public static CustomNumberOption NumberOfImpostorAssassins;
        public static CustomNumberOption NumberOfNeutralAssassins;
        public static CustomToggleOption AmneTurnImpAssassin;
        public static CustomToggleOption AmneTurnNeutAssassin;
        public static CustomToggleOption TraitorCanAssassin;
        public static CustomNumberOption AssassinKills;
        public static CustomToggleOption AssassinMultiKill;
        public static CustomToggleOption AssassinCrewmateGuess;
        public static CustomToggleOption AssassinSnitchViaCrewmate;
        public static CustomToggleOption AssassinGuessNeutralBenign;
        public static CustomToggleOption AssassinGuessNeutralEvil;
        public static CustomToggleOption AssassinGuessNeutralKilling;
        public static CustomToggleOption AssassinGuessImpostors;
        public static CustomToggleOption AssassinGuessModifiers;
        public static CustomToggleOption AssassinGuessLovers;
        public static CustomToggleOption AssassinateAfterVoting;

        public static CustomHeaderOption Underdog;
        public static CustomNumberOption UnderdogKillBonus;
        public static CustomToggleOption UnderdogIncreasedKC;

        public static CustomHeaderOption Vigilante;
        public static CustomNumberOption VigilanteKills;
        public static CustomToggleOption VigilanteMultiKill;
        public static CustomToggleOption VigilanteGuessNeutralBenign;
        public static CustomToggleOption VigilanteGuessNeutralEvil;
        public static CustomToggleOption VigilanteGuessNeutralKilling;
        public static CustomToggleOption VigilanteGuessLovers;
        public static CustomToggleOption VigilanteAfterVoting;

        public static CustomHeaderOption Haunter;
        public static CustomNumberOption HaunterTasksRemainingClicked;
        public static CustomNumberOption HaunterTasksRemainingAlert;
        public static CustomToggleOption HaunterRevealsNeutrals;
        public static CustomStringOption HaunterCanBeClickedBy;

        public static CustomHeaderOption Grenadier;
        public static CustomNumberOption GrenadeCooldown;
        public static CustomNumberOption GrenadeDuration;
        public static CustomToggleOption GrenadierIndicators;
        public static CustomToggleOption GrenadierVent;
        public static CustomNumberOption FlashRadius;

        public static CustomHeaderOption Veteran;
        public static CustomToggleOption KilledOnAlert;
        public static CustomNumberOption AlertCooldown;
        public static CustomNumberOption AlertDuration;
        public static CustomNumberOption MaxAlerts;

        public static CustomHeaderOption Tracker;
        public static CustomNumberOption UpdateInterval;
        public static CustomNumberOption TrackCooldown;
        public static CustomToggleOption ResetOnNewRound;
        public static CustomNumberOption MaxTracks;

        public static CustomHeaderOption Trapper;
        public static CustomNumberOption TrapCooldown;
        public static CustomToggleOption TrapsRemoveOnNewRound;
        public static CustomNumberOption MaxTraps;
        public static CustomNumberOption MinAmountOfTimeInTrap;
        public static CustomNumberOption TrapSize;
        public static CustomNumberOption MinAmountOfPlayersInTrap;

        public static CustomHeaderOption Poisoner;
        public static CustomNumberOption PoisonCooldown;
        public static CustomNumberOption PoisonDuration;
        public static CustomToggleOption PoisonerVent;

        public static CustomHeaderOption Traitor;
        public static CustomNumberOption LatestSpawn;
        public static CustomToggleOption NeutralKillingStopsTraitor;

        public static CustomHeaderOption Amnesiac;
        public static CustomToggleOption RememberArrows;
        public static CustomNumberOption RememberArrowDelay;

        public static CustomHeaderOption Medium;
        public static CustomNumberOption MediateCooldown;
        public static CustomToggleOption ShowMediatePlayer;
        public static CustomToggleOption ShowMediumToDead;
        public static CustomStringOption DeadRevealed;

        public static CustomHeaderOption Survivor;
        public static CustomNumberOption VestCd;
        public static CustomNumberOption VestDuration;
        public static CustomNumberOption VestKCReset;
        public static CustomNumberOption MaxVests;

        public static CustomHeaderOption GuardianAngel;
        public static CustomNumberOption ProtectCd;
        public static CustomNumberOption ProtectDuration;
        public static CustomNumberOption ProtectKCReset;
        public static CustomNumberOption MaxProtects;
        public static CustomStringOption ShowProtect;
        public static CustomStringOption GaOnTargetDeath;
        public static CustomToggleOption GATargetKnows;
        public static CustomToggleOption GAKnowsTargetRole;
        public static CustomToggleOption GACanHaveNeutralTargets;

        public static CustomHeaderOption Mystic;
        public static CustomNumberOption MysticArrowDuration;
        
        public static CustomNumberOption InitialExamineCooldown;
        public static CustomNumberOption ExamineCooldown;
        public static CustomNumberOption RecentKill;
        public static CustomToggleOption MysticReportOn;
        public static CustomNumberOption MysticoleDuration;
        public static CustomNumberOption MysticFactionDuration;

        public static CustomHeaderOption Blackmailer;
        public static CustomNumberOption BlackmailCooldown;

        public static CustomHeaderOption Plaguebearer;
        public static CustomNumberOption InfectCooldown;

        public static CustomNumberOption PestKillCooldown;
        public static CustomToggleOption PestVent;

        public static CustomHeaderOption Werewolf;
        public static CustomNumberOption RampageCooldown;
        public static CustomNumberOption RampageDuration;
        public static CustomNumberOption RampageKillCooldown;
        public static CustomToggleOption WerewolfVent;

        public static CustomHeaderOption Escapist;
        public static CustomNumberOption EscapeCooldown;
        public static CustomToggleOption EscapistVent;

        public static CustomHeaderOption Giant;
        public static CustomNumberOption GiantSlow;

        public static CustomHeaderOption Flash;
        public static CustomNumberOption FlashSpeed;

        public static CustomHeaderOption Diseased;
        public static CustomNumberOption DiseasedKillMultiplier;

        public static CustomHeaderOption Bait;
        public static CustomNumberOption BaitMinDelay;
        public static CustomNumberOption BaitMaxDelay;

        public static CustomHeaderOption Lovers;
        public static CustomToggleOption BothLoversDie;
        public static CustomNumberOption LovingImpPercent;
        public static CustomToggleOption NeutralLovers;

        public static Func<object, string> PercentFormat { get; } = value => $"{value:0}%";
        private static Func<object, string> CooldownFormat { get; } = value => $"{value:0.0#}s";
        private static Func<object, string> MultiplierFormat { get; } = value => $"{value:0.0#}x";


        public static void GenerateAll()
        {
            var num = 0;

            Patches.ExportButton = new Export(num++);
            Patches.ImportButton = new Import(num++);


            CrewInvestigativeRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#8BFDFDFF>Crewmate</color> Investigative Roles");
            HaunterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D3D3D3FF>Haunter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            InvestigatorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00B3B3FF>Detective</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MysticOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SeerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFCC80FF>Snitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SnitchOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SpyOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#CCA3CCFF>Spy</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrackerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TrapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewKillingRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#8BFDFDFF>Crewmate</color> <color=#FF0000FF>Killing</color> Roles");
            SheriffOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VeteranOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VigilanteOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color>", 0f, 0f, 100f, 10f,
                PercentFormat);


            CrewSupportRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#8BFDFDFF>Crewmate</color> Support Roles");
            EngineerOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MediumOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            AltruistOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#660000FF>Altruist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MedicOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#006600FF>Medic</color>", 0f, 0f, 100f, 10f,
                PercentFormat);                

            CrewChaosRoles = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#8BFDFDFF>Crewmate</color> Chaos Roles");
            MayorOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwapperOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TimeLordOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#0000FFFF>Chronos</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TransporterOn = new CustomNumberOption(true, num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
    

            NeutralBenignRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#45a85e>Neutral</color> Benign Roles");
            AmnesiacOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GuardianAngelOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SurvivorOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFE64DFF>Survivor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralEvilRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#45a85e>Neutral</color> Evil Roles");
            ExecutionerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JesterOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PhantomOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            VultureOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#69460a>Vulture</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PyromaniacOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#e89d51>Pyromaniac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            NeutralKillingRoles = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Roles");
            ArsonistOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            PlaguebearerOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GlitchOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JuggernautOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#A12B56FF>Juggernaut</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            WerewolfOn = new CustomNumberOption(true, num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorConcealingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Impostor</color> Concealing Roles");
            EscapistOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GrenadierOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MorphlingOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SwooperOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorKillingRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Impostor</color> <color=#FF0000FF>Killing</color> Roles");
            PoisonerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Vampire</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TraitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorSupportRoles = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Impostor</color> Support Roles");
            BlackmailerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Blackmailer</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            JanitorOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Janitor</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MinerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UndertakerOn = new CustomNumberOption(true, num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            CrewmateModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#8BFDFDFF>Crewmate</color> Modifiers");
            BaitOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#00B3B3FF>Bait</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            BlindOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#AAAAAAFF>Blind</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DiseasedOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            MultitaskerOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF804DFF>Multitasker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TorchOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFFF99FF>Torch</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GlobalModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "Global Modifiers");
            ButtonBarryOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#E600FFFF>Button Barry</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            FlashOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            GiantOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            LoversOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            RadarOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0080FF>Paranoiac</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            SleuthOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#803333FF>Sleuth</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            TiebreakerOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#99E699FF>Tiebreaker</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DrunkOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#2a4d0d>Drunk</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            ImpostorModifiers = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Impostor</color> Modifiers");
            DisperserOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>Disperser</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            DoubleShotOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>Double Shot</color>", 0f, 0f, 100f, 10f,
                PercentFormat);
            UnderdogOn = new CustomNumberOption(true, num++, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>", 0f, 0f, 100f, 10f,
                PercentFormat);

            GameModeSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Game Mode Settings");
            GameMode = new CustomStringOption(num++, MultiMenu.main, "Game Mode", new[] {"Classic", "All Any", "<color=#FF0000FF>Killing</color> Only"});

            ClassicSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Classic Game Mode Settings");
            MinNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Min <color=#45a85e>Neutral</color> Non-<color=#FF0000FF>Killing</color> Roles", 1f, 0f, 5f, 1f);
            MaxNeutralNonKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Max <color=#45a85e>Neutral</color> Non-<color=#FF0000FF>Killing</color> Roles", 1f, 0f, 5f, 1f);
            MinNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Min <color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Roles", 1f, 0f, 4f, 1f);
            MaxNeutralKillingRoles =
                new CustomNumberOption(num++, MultiMenu.main, "Max <color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Roles", 1f, 0f, 4f, 1f);

            AllAnySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "All Any Settings");
            RandomNumberImps = new CustomToggleOption(num++, MultiMenu.main, "Random Number Of <color=#FF0000FF>Impostors</color>", true);

            KillingOnlySettings =
                new CustomHeaderOption(num++, MultiMenu.main, "<color=#FF0000FF>Killing</color> Only Settings");
            NeutralRoles =
                new CustomNumberOption(num++, MultiMenu.main, "<color=#45a85e>Neutral</color> Roles", 1f, 0f, 5f, 1f);
            VeteranCount =
                new CustomNumberOption(num++, MultiMenu.main, "<color=#998040FF>Veteran</color> Count", 1f, 0f, 5f, 1f);
            VigilanteCount =
                new CustomNumberOption(num++, MultiMenu.main, "<color=#FFFF99FF>Gambler</color> Count", 1f, 0f, 5f, 1f);
            AddArsonist = new CustomToggleOption(num++, MultiMenu.main, "Add <color=#FF4D00FF>Arsonist</color>", true);
            AddPlaguebearer = new CustomToggleOption(num++, MultiMenu.main, "Add <color=#E6FFB3FF>Plaguebearer</color>", true);

            MapSettings = new CustomHeaderOption(num++, MultiMenu.main, "Map Settings");
            RandomMapEnabled = new CustomToggleOption(num++, MultiMenu.main, "Choose Random Map", false);
            RandomMapSkeld = new CustomNumberOption(num++, MultiMenu.main, "Skeld Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapMira = new CustomNumberOption(num++, MultiMenu.main, "Mira Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapPolus = new CustomNumberOption(num++, MultiMenu.main, "Polus Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapAirship = new CustomNumberOption(num++, MultiMenu.main, "Airship Chance", 0f, 0f, 100f, 10f, PercentFormat);
            RandomMapSubmerged = new CustomNumberOption(num++, MultiMenu.main, "Submerged Chance", 0f, 0f, 100f, 10f, PercentFormat);
            AutoAdjustSettings = new CustomToggleOption(num++, MultiMenu.main, "Auto Adjust Settings", false);
            SmallMapHalfVision = new CustomToggleOption(num++, MultiMenu.main, "Half Vision On Skeld/Mira HQ", false);
            SmallMapDecreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Mira HQ Decreased Cooldowns", 0f, 0f, 15f, 2.5f, CooldownFormat);
            LargeMapIncreasedCooldown =
                new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Increased Cooldowns", 0f, 0f, 15f, 2.5f, CooldownFormat);
            SmallMapIncreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Short Tasks", 0, 0, 5, 1);
            SmallMapIncreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Skeld/Mira HQ Increased Long Tasks", 0, 0, 3, 1);
            LargeMapDecreasedShortTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Short Tasks", 0, 0, 5, 1);
            LargeMapDecreasedLongTasks =
                 new CustomNumberOption(num++, MultiMenu.main, "Airship/Submerged Decreased Long Tasks", 0, 0, 3, 1);

            BetterPolusSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Better Map Settings");
            VentImprovements = new CustomToggleOption(num++, MultiMenu.main, "Better Polus Vent Layout", false);
            VitalsLab = new CustomToggleOption(num++, MultiMenu.main, "Vitals Moved To Lab", false);
            ColdTempDeathValley = new CustomToggleOption(num++, MultiMenu.main, "Cold Temp Moved To Death Valley", false);
            WifiChartCourseSwap =
                new CustomToggleOption(num++, MultiMenu.main, "Reboot Wifi And Chart Course Swapped", false);

            CustomGameSettings =
                new CustomHeaderOption(num++, MultiMenu.main, "Custom Game Settings");
            SeeTasksDuringRound = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Round", false);
            SeeTasksDuringMeeting = new CustomToggleOption(num++, MultiMenu.main, "See Tasks During Meetings", false);
            SeeTasksWhenDead = new CustomToggleOption(num++, MultiMenu.main, "See Tasks When Dead", true);
            ColourblindComms = new CustomToggleOption(num++, MultiMenu.main, "Colourblind Comms", false);
            EveryoneVenting = new CustomToggleOption(num++, MultiMenu.main, "Enable Everyone Can Vent Mode", false);
            DeadSeeRoles =
                new CustomToggleOption(num++, MultiMenu.main, "Dead Can See Everyone's Roles/Votes", false);
            RandomSpawns =
                new CustomToggleOption(num++, MultiMenu.main, "Enable Random Spawns", true);
            VanillaGame = new CustomNumberOption(num++, MultiMenu.main, "Probability Of A Completely Vanilla Game", 0f, 0f, 100f, 5f,
                PercentFormat);
            InitialCooldowns =
                new CustomNumberOption(num++, MultiMenu.main, "Game Start Cooldowns", 10f, 10f, 30f, 2.5f, CooldownFormat);
            ParallelMedScans = new CustomToggleOption(num++, MultiMenu.main, "Multiple People Can MedScan", false);
            SkipButtonDisable = new CustomStringOption(num++, MultiMenu.main, "Disable Meeting Skip Button", new[] { "Never", "Emergency Meeting", "Always" });
            DisableLevels = new CustomToggleOption(num++, MultiMenu.main, "No Level Icons", false);
            WhiteNameplates = new CustomToggleOption(num++, MultiMenu.main, "No Nameplates", false);


            Assassin = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Impostor Abilities</color>");
            ImpostorSeeRoles = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Impostors</color> Can See The Roles Of Their Team", false);
            NumberOfImpostorAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of Impostor <color=#FF0000FF>Assassins</color>", 1, 0, 4, 1);
            NumberOfNeutralAssassins = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of <color=#45a85e>Neutral</color> <color=#FF0000FF>Assassins</color>", 1, 0, 5, 1);
            AmneTurnImpAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned Impostor Gets Ability", false);
            AmneTurnNeutAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Amnesiac Turned <color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Gets Ability", false);
            TraitorCanAssassin = new CustomToggleOption(num++, MultiMenu.imposter, "Traitor Gets Ability", false);
            AssassinKills = new CustomNumberOption(num++, MultiMenu.imposter, "Number Of <color=#FF0000FF>Assassin</color> Kills", 1, 1, 15, 1);
            AssassinMultiKill = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Kill More Than Once Per Meeting", false);
            AssassinCrewmateGuess = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess \"<color=#8BFDFDFF>Crewmate</color>\"", false);
            AssassinSnitchViaCrewmate = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Informant Via \"Crewmate\" Guess", false);
            AssassinGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess <color=#45a85e>Neutral</color> Benign Roles", false);
            AssassinGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess <color=#45a85e>Neutral</color> Evil Roles", false);
            AssassinGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess <color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Roles", false);
            AssassinGuessImpostors = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#45a85e>Neutral</color> <color=#FF0000FF>Assassin</color> Can Guess <color=#FF0000FF>Impostor</color> Roles", false);
            AssassinGuessModifiers = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess Some Modifiers", false);
            AssassinGuessLovers = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess <color=#FF66CCFF>Lovers</color>", false);
            AssassinateAfterVoting = new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Assassin</color> Can Guess After Voting", false);

            Haunter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>Haunter</color>");
            HaunterTasksRemainingClicked =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When <color=#d3d3d3FF>Haunter</color> Can Be Clicked", 5, 1, 15, 1);
            HaunterTasksRemainingAlert =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Alert Is Sent", 1, 1, 5, 1);
            HaunterRevealsNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#d3d3d3FF>Haunter</color> Reveals Neutral Roles", false);
            HaunterCanBeClickedBy = new CustomStringOption(num++, MultiMenu.crewmate, "Who Can Click <color=#d3d3d3FF>Haunter</color>", new[] { "All", "Non-Crew", "Imps Only" });

            Investigator =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00B3B3FF>Investigator</color>");
            FootprintSize = new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Size", 4f, 1f, 10f, 1f);
            FootprintInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Interval", 0.1f, 0.05f, 1f, 0.05f, CooldownFormat);
            FootprintDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "Footprint Duration", 10f, 1f, 15f, 0.5f, CooldownFormat);
            AnonymousFootPrint = new CustomToggleOption(num++, MultiMenu.crewmate, "Anonymous Footprint", false);
            VentFootprintVisible = new CustomToggleOption(num++, MultiMenu.crewmate, "Footprint Vent Visible", false);

            Mystic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#4D99E6FF>Mystic</color>");
            MysticArrowDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Dead Body Arrow Duration", 0.1f, 0f, 1f, 0.05f, CooldownFormat);
            InitialExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Initial Examine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ExamineCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Examine Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            RecentKill =
                new CustomNumberOption(num++, MultiMenu.crewmate, "How Long Players Stay Bloody For", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MysticReportOn = new CustomToggleOption(num++, MultiMenu.crewmate, "Show <color=#4D99E6FF>Mystic</color> Reports", true);
            MysticoleDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#4D99E6FF>Mystic</color> Will Have Role", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MysticFactionDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#4D99E6FF>Mystic</color> Will Have Faction", 30f, 0f, 60f, 2.5f,
                    CooldownFormat);


            Seer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Snitch</color>");
            SeerCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFCC80FF>Snitch</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            CrewKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Crewmate <color=#FF0000FF>Killing</color> Roles Show Evil", false);
            NeutBenignRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#45a85e>Neutral</color> Benign Roles Show Evil", false);
            NeutEvilRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#45a85e>Neutral</color> Evil Roles Show Evil", false);
            NeutKillingRed =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#45a85e>Neutral</color> <color=#FF0000FF>Killing</color> Roles Show Evil", false);
            TraitorColourSwap =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Traitor Does Not Swap Colours", false);

            Snitch = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color>");
            SnitchOnLaunch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Knows Who They Are On Game Start", false);
            SnitchSeesNeutrals = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Sees <color=#45a85e>Neutral</color> Roles", false);
            SnitchTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Tasks Remaining When Revealed", 1, 1, 5, 1);
            SnitchSeesImpInMeeting = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Sees Impostors In Meetings", true);
            SnitchSeesTraitor = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#D4AF37FF>Informant</color> Sees Traitor", true);

            Tracker =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#009900FF>Tracker</color>");
            UpdateInterval =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Arrow Update Interval", 5f, 0.5f, 15f, 0.5f, CooldownFormat);
            TrackCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Track Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ResetOnNewRound = new CustomToggleOption(num++, MultiMenu.crewmate, "Tracker Arrows Reset After Each Round", false);
            MaxTracks = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Tracks Per Round", 5, 1, 15, 1);

            Trapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A7D1B3FF>Trapper</color>");
            MinAmountOfTimeInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Min Amount Of Time In Trap To Register", 1f, 0f, 15f, 0.5f, CooldownFormat);
            TrapCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            TrapsRemoveOnNewRound =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Traps Removed After Each Round", true);
            MaxTraps =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Traps Per Game", 5, 1, 15, 1);
            TrapSize =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Trap Size", 1f, 0.5f, 5f, 0.5f, MultiplierFormat);
            MinAmountOfPlayersInTrap =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Minimum Number Of Roles Required To Trigger Trap", 3, 1, 5, 1);

            Sheriff =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color>");
            SheriffKillOther =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Miskill Kills Crewmate", false);
            SheriffKillsJester =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills Jester", false);
            SheriffKillsGlitch =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#00FF00FF>Glitch</color>", false);
            SheriffKillsExecutioner =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#8C4005FF>Executioner</color>", false);
            SheriffKillsArsonist =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#FF4D00FF>Arsonist</color>", false);
            SheriffKillsPyromaniac =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#e89d51>Pyromaniac</color>", false);
            SheriffKillsWerewolf =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#A86629FF>Werewolf</color>", false);
            SheriffKillsPlaguebearer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kills <color=#E6FFB3FF>Plaguebearer</color>", false);
            SheriffKillCd =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Kill Cooldown", 25f, 10f, 40f, 2.5f, CooldownFormat);
            SheriffBodyReport = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF00FF>Sheriff</color> Can Report Who They've Killed");

            Veteran =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#998040FF>Veteran</color>");
            KilledOnAlert =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Can Be Killed On Alert", false);
            AlertCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Alert Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            AlertDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Alert Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MaxAlerts = new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Alerts", 5, 1, 15, 1);

            Vigilante = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color>");
            VigilanteKills = new CustomNumberOption(num++, MultiMenu.crewmate, "Number Of <color=#FFFF99FF>Gambler</color> Kills", 1, 1, 15, 1);
            VigilanteMultiKill = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Kill More Than Once Per Meeting", false);
            VigilanteGuessNeutralBenign = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Guess Neutral Benign Roles", false);
            VigilanteGuessNeutralEvil = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Guess Neutral Evil Roles", false);
            VigilanteGuessNeutralKilling = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Guess Neutral <color=#FF0000FF>Killing</color> Roles", false);
            VigilanteGuessLovers = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Guess Modifiers", false);
            VigilanteAfterVoting = new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#FFFF99FF>Gambler</color> Can Guess After Voting", false);


            Engineer =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color>");
            EngineerPer =
                new CustomStringOption(num++, MultiMenu.crewmate, "<color=#FFA60AFF>Engineer</color> Fix Per", new[] { "Round", "Game" });

            Mayor =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color>");
            MayorVoteBank =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Initial Mayor <color=#704FA8FF>Mayor</color> Bank", 1, 1, 15, 1);
            MayorAnonymous =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#704FA8FF>Mayor</color> Votes Show Anonymous", false);

            Medium =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color>");
            MediateCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#A680FFFF>Medium</color> Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);
            ShowMediatePlayer =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal Appearance Of Mediate Target", true);
            ShowMediumToDead =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Reveal The <color=#A680FFFF>Medium</color> To The Mediate Target", true);
            DeadRevealed =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Is Revealed With Mediate", new[] { "Oldest Dead", "Newest Dead", "All Dead" });
            
            Altruist = new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruist</color>");
            ReviveDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#660000FF>Altruist</color> Revive Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            AltruistTargetBody =
                new CustomToggleOption(num++, MultiMenu.crewmate, "Target's Body Disappears On Beginning Of Revive", false);

            Medic =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#006600FF>Medic</color>");
            ShowShielded =
                new CustomStringOption(num++, MultiMenu.crewmate, "Show Shielded Player",
                    new[] { "Self", "<color=#006600FF>Medic</color>", "Self+<color=#006600FF>Medic</color>", "Everyone" });
            WhoGetsNotification =
                new CustomStringOption(num++, MultiMenu.crewmate, "Who Gets Murder Attempt Indicator",
                    new[] { "<color=#006600FF>Medic</color>", "Shielded", "Everyone", "Nobody" });
            ShieldBreaks = new CustomToggleOption(num++, MultiMenu.crewmate, "Shield Breaks On Murder Attempt", false);
            MedicReportSwitch = new CustomToggleOption(num++, MultiMenu.crewmate, "Show <color=#006600FF>Medic</color> Reports");
            MedicReportNameDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#006600FF>Medic</color> Will Have Name", 0f, 0f, 60f, 2.5f,
                    CooldownFormat);
            MedicReportColorDuration =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Time Where <color=#006600FF>Medic</color> Will Have Color Type", 15f, 0f, 60f, 2.5f,
                    CooldownFormat);

            Swapper =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color>");
            SwapperButton =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#66E666FF>Swapper</color> Can Button", true);

            TimeLord =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#0000FFFF>Chronos</color>");
            RewindRevive = new CustomToggleOption(num++, MultiMenu.crewmate, "Revive During Rewind", false);
            RewindDuration = new CustomNumberOption(num++, MultiMenu.crewmate, "Rewind Duration", 2f, 2f, 5f, 0.5f, CooldownFormat);
            RewindCooldown = new CustomNumberOption(num++, MultiMenu.crewmate, "Rewind Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RewindMaxUses =
                 new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Rewinds", 5, 1, 15, 1);
            TimeLordVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#0000FFFF>Chronos</color> Can Use Vitals", false);

            Transporter =
                new CustomHeaderOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color>");
            TransportCooldown =
                new CustomNumberOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            TransportMaxUses =
                new CustomNumberOption(num++, MultiMenu.crewmate, "Maximum Number Of Transports", 5, 1, 15, 1);
            TransporterVitals =
                new CustomToggleOption(num++, MultiMenu.crewmate, "<color=#00EEFFFF>Transporter</color> Can Use Vitals", true);

            Amnesiac = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color>");
            RememberArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#80B2FFFF>Amnesiac</color> Gets Arrows Pointing To Dead Bodies", false);
            RememberArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Time After Death Arrow Appears", 5f, 0f, 15f, 1f, CooldownFormat);

            GuardianAngel =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color>");
            ProtectCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            ProtectDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Protect Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            ProtectKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Reset When Protected", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxProtects =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Number Of Protects", 5, 1, 15, 1);
            ShowProtect =
                new CustomStringOption(num++, MultiMenu.neutral, "Show Protected Player",
                    new[] { "Self", "<color=#B3FFFFFF>GA</color>", "Self+<color=#B3FFFFFF>GA</color>", "Everyone" });
            GaOnTargetDeath = new CustomStringOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color> Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            GATargetKnows =
                new CustomToggleOption(num++, MultiMenu.neutral, "Target Knows <color=#B3FFFFFF>Guardian Angel</color> Exists", false);
            GAKnowsTargetRole =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color> Knows Targets Role", false);
            GACanHaveNeutralTargets =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#B3FFFFFF>Guardian Angel</color> Can Target Neutrals", false);

            Survivor =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFE64DFF>Survivor</color>");
            VestCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "Vest Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VestDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "Vest Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            VestKCReset =
                new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Reset On Attack", 2.5f, 0f, 15f, 0.5f, CooldownFormat);
            MaxVests =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Number Of Vests", 5, 1, 15, 1);

            Executioner =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color>");
            OnTargetDead = new CustomStringOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color> Becomes On Target Dead",
                new[] { "Crew", "Amnesiac", "Survivor", "Jester" });
            ExecutionerButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#8C4005FF>Executioner</color> Can Button", true);

            Jester =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color>");
            JesterButton =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color> Can Button", true);
            JesterVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color> Can Hide In Vents", false);
            JesterSwitchVents =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color> Can Switch Between Vents", false);
            JesterImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FFBFCCFF>Jester</color> Has Impostor Vision", false);

            Phantom =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#662962FF>Phantom</color>");
            PhantomTasksRemaining =
                 new CustomNumberOption(num++, MultiMenu.neutral, "Tasks Remaining When <color=#662962FF>Phantom</color> Can Be Clicked", 5, 1, 15, 1);
            
            Vulture =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#69460a>Vulture</color>");
            VultureCd =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#69460a>Vulture</color> Eat Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            VultureBodies =
                new CustomNumberOption(num++, MultiMenu.neutral, "Number Of Bodies That Needs To Eat",5, 1, 15, 1);
            EatArrows =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#69460a>Vulture</color> Has Arrows To Bodies", false);
            EatArrowDelay =
                new CustomNumberOption(num++, MultiMenu.neutral, "Arrow Delay", 5f, 0f, 15f, 1f, CooldownFormat);
            VultureVent = 
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#69460a>Vulture</color> Can Vent", false);
            
            Pyromaniac =
               new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#e89d51>Pyromaniac</color>");
            GasolineCd =
               new CustomNumberOption(num++, MultiMenu.neutral, "<color=#e89d51>Pyromaniac</color> Gasoline Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PyromaniacEndGame =
            PyromaniacEndGame = 
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#e89d51>Pyromaniac</color> Keeps The Game Going When They are Alive", false);
    

            Arsonist = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color>");
            DouseCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Douse Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MaxDoused =
                new CustomNumberOption(num++, MultiMenu.neutral, "Maximum Alive Players Doused", 5, 1, 15, 1);
            ArsoImpVision =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#FF4D00FF>Arsonist</color> Has Impostor Vision", false);
            IgniteCdRemoved =
                new CustomToggleOption(num++, MultiMenu.neutral, "Ignite Cooldown Removed When <color=#FF4D00FF>Arsonist</color> Is Last Killer", false);
            ArsonistVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Enable <color=#FF4D00FF>Arsonist</color> Vent", false);                

            Plaguebearer = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color>");
            InfectCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#E6FFB3FF>Plaguebearer</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Pestilence Kill Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PestVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "Pestilence Can Vent", false);

            TheGlitch =
                new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color>");
            MimicCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MimicDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Mimic Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            HackCooldownOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            HackDurationOption = new CustomNumberOption(num++, MultiMenu.neutral, "Hack Duration", 10f, 1f, 15f, 1f, CooldownFormat);
            GlitchKillCooldownOption =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Kill Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            GlitchHackDistanceOption =
                new CustomStringOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Hack Distance", new[] { "Short", "Normal", "Long" });
            GlitchVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#00FF00FF>Glitch</color> Can Vent", false);
            
             Juggernaut = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A12B56FF>Juggernaut</color>");
            JuggKillCooldown = new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A12B56FF>Juggernaut</color> Kill Cooldown", 25f, 10f, 120f, 2.5f, CooldownFormat);
            JuggKillBonus = new CustomNumberOption(num++, MultiMenu.neutral, "Kill Cooldown Bonus", 5f, 2.5f, 30f, 2.5f, CooldownFormat);
            JuggVent = new CustomToggleOption(num++, MultiMenu.neutral, "<color=#A12B56FF>Juggernaut</color> Can Vent", false);

            Werewolf = new CustomHeaderOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color>");
            RampageCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageDuration =
                new CustomNumberOption(num++, MultiMenu.neutral, "<color=#A86629FF>Rampage</color> Duration", 25f, 10f, 60f, 2.5f, CooldownFormat);
            RampageKillCooldown =
                new CustomNumberOption(num++, MultiMenu.neutral, "Rampage Kill Cooldown", 10f, 0.5f, 15f, 0.5f, CooldownFormat);
            WerewolfVent =
                new CustomToggleOption(num++, MultiMenu.neutral, "<color=#A86629FF>Werewolf</color> Can Vent When Rampaged", false);

            Escapist =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color>");
            EscapeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Recall Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            EscapistVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Escapist</color> Can Vent", false);

            Grenadier =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color>");
            GrenadeCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash <color=#FF0000FF>Grenadier</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            GrenadeDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Grenade Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            FlashRadius =
                new CustomNumberOption(num++, MultiMenu.imposter, "Flash Radius", 1f, 0.25f, 5f, 0.25f, MultiplierFormat);
            GrenadierIndicators =
                new CustomToggleOption(num++, MultiMenu.imposter, "Indicate Flashed Crewmates", false);
            GrenadierVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Grenadier</color> Can Vent", false);

            Morphling =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color>");
            MorphlingCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            MorphlingDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            MorphlingVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Morphling</color> Can Vent", false);

            Swooper = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color>");

            SwoopCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color> Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            SwoopDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Swoop Duration", 10f, 5f, 15f, 1f, CooldownFormat);
            SwooperVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Swooper</color> Can Vent", false);

            Poisoner =
                new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Vampire</color>");
            PoisonCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Bite Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            PoisonDuration =
                new CustomNumberOption(num++, MultiMenu.imposter, "Bite Kill Delay", 5f, 1f, 15f, 1f, CooldownFormat);
            PoisonerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Vampire</color> Can Use Vent", false);

            Traitor = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color>");
            LatestSpawn = new CustomNumberOption(num++, MultiMenu.imposter, "Minimum People Alive When <color=#FF0000FF>Traitor</color> Can Spawn", 5, 3, 15, 1);
            NeutralKillingStopsTraitor =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Traitor</color> Won't Spawn If Any Neutral <color=#FF0000FF>Killing</color> Is Alive", false);

            Blackmailer = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Blackmailer</color>");
            BlackmailCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Initial Blackmail Cooldown", 10f, 1f, 15f, 1f, CooldownFormat);

            Miner = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Miner</color>");
            MineCooldown =
                new CustomNumberOption(num++, MultiMenu.imposter, "Mine Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);

            Undertaker = new CustomHeaderOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color>");
            DragCooldown = new CustomNumberOption(num++, MultiMenu.imposter, "Drag Cooldown", 25f, 10f, 60f, 2.5f, CooldownFormat);
            UndertakerVent =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color> Can Vent", false);
            UndertakerVentWithBody =
                new CustomToggleOption(num++, MultiMenu.imposter, "<color=#FF0000FF>Undertaker</color> Can Vent While Dragging", false);


            Bait = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#00B3B3FF>Bait</color>");
            BaitMinDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Minimum Delay for the <color=#00B3B3FF>Bait</color> Report", 0f, 0f, 15f, 0.5f, CooldownFormat);
            BaitMaxDelay = new CustomNumberOption(num++, MultiMenu.modifiers, "Maximum Delay for the <color=#00B3B3FF>Bait</color> Report", 1f, 0f, 15f, 0.5f, CooldownFormat);

            Diseased = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#808080FF>Diseased</color>");
            DiseasedKillMultiplier = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#808080FF>Diseased</color> Kill Multiplier", 3f, 1.5f, 5f, 0.5f, MultiplierFormat);

            Flash = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color>");
            FlashSpeed = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF8080FF>Flash</color> Speed", 1.25f, 1.05f, 2.5f, 0.05f, MultiplierFormat);

            Giant = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FFB34DFF>Giant</color>");
            GiantSlow = new CustomNumberOption(num++, MultiMenu.modifiers, "color=#FFB34DFF>Giant</color> Speed", 0.75f, 0.5f, 1f, 0.05f, MultiplierFormat);

            Lovers =
                new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Lovers</color>");
            BothLoversDie = new CustomToggleOption(num++, MultiMenu.modifiers, "Both <color=#FF66CCFF>Lovers</color> Die");
            LovingImpPercent = new CustomNumberOption(num++, MultiMenu.modifiers, "<color=#FF66CCFF>Loving</color> Impostor Probability", 20f, 0f, 100f, 10f,
                PercentFormat);
            NeutralLovers = new CustomToggleOption(num++, MultiMenu.modifiers, "Neutral Roles Can Be Lovers");

            Underdog = new CustomHeaderOption(num++, MultiMenu.modifiers, "<color=#FF0000FF>Underdog</color>");
            UnderdogKillBonus = new CustomNumberOption(num++, MultiMenu.modifiers, "Kill Cooldown Bonus", 5f, 2.5f, 30f, 2.5f, CooldownFormat);
            UnderdogIncreasedKC = new CustomToggleOption(num++, MultiMenu.modifiers, "Increased Kill Cooldown When 2+ Imps", true);
        }
    }
}