using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional5xRecipes
{
    [HarmonyPatch]
    public class Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(ObjectDB), "Awake")]
        public static void RecipeTable_Awake_5xRecipes(ref ObjectDB __instance)
        {
            //__instance.

        }
    }
}
