using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Log = EnemyFix.Utilities.Logger;

namespace EnemyFix.Patches
{
    [HarmonyPatch(typeof(StartOfRound), "EndOfGame")]
    public class RemoveEnemiesPatch
    {
        [HarmonyPrefix]
        public static void Prefix()
        {
            Log.LogWarning(">>>> Despawning enemies early to fix the unspawned enemies on the map!");
            RoundManager.Instance.UnloadSceneObjectsEarly();
        }
    }
}
