using BaraphorSharedLibs;
using BepInEx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional5xRecipes
{
    [BepInPlugin("com.baraphor.additional5xrecipes", "Additional 5x Recipes", "1.0.0")]
    [BepInProcess("valheim.exe")]
    public class Additional5xRecipesMod : BaseValheimMod
    {
        public Additional5xRecipesMod() : base("com.baraphor.additional5xrecipes")
        {
            // Constructor Needs some code, otherwise it gets stripped
            Logger.LogDebug("Loaded com.baraphor.additional5xrecipes");
        }

        public void Awake()
        {
            Harmony.PatchAll();
        }
    }
}
