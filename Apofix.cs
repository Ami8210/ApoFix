using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using Apofix;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;
using Apofix.cards;
using Apofix.cards;
using Apofix.Cards;


namespace Apofix
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class Apofix : BaseUnityPlugin
    {
        private const string ModId = "com.Apo.llon.Ami";
        private const string ModName = "Apollon";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "ApoFix";
        public static Apofix instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<Slim>();
            CustomCard.BuildCard<Callibri>();
            CustomCard.BuildCard<Seraphine>();
            CustomCard.BuildCard<Tiny>();
            CustomCard.BuildCard<enlarge>();

        }
    }
}
