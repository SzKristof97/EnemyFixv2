using BepInEx;
using EnemyFix.Patches;
using EnemyFix.Utilities;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log = EnemyFix.Utilities.Logger;

namespace EnemyFix
{
    [BepInPlugin(PluginInfos.GUID, PluginInfos.NAME, PluginInfos.VERSION)]
    [BepInProcess("Lethal Company.exe")]
    public class Base : BaseUnityPlugin
    {
        private static Base _instance;
        public static Base Instance
        {
            get { return _instance; }
            private set { _instance = value; }
        }

        private static Harmony _harmony;

        private void Awake()
        {
            if (_harmony == null) _harmony = new Harmony(PluginInfos.GUID);

            _harmony.PatchAll(typeof(Base));
            _harmony.PatchAll(typeof(RemoveEnemiesPatch));

            Log.LogInfo("Successfully awakened!");
        }
    }
}
