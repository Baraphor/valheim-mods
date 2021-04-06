using BaraphorSharedLibs;
using BepInEx;
using JotunnLib.Managers;

using System;
using System.Reflection;

namespace MoreStacks
{
    [BepInPlugin("com.baraphor.morestacks", "More Stacks", "1.0.0")]
    [BepInProcess("valheim.exe")]
    [BepInDependency(JotunnLib.JotunnLib.ModGuid)]
    public class MoreStacksMod : BaseValheimMod
    {
        public MoreStacksMod() : base("com.baraphor.morestacks")
        {
            // Constructor Needs some code, otherwise it gets stripped
            Logger.LogDebug("Loaded com.baraphor.morestacks");
        }

        public void Awake()
        {
            LoadAssetBundle("morestacks", Assembly.GetExecutingAssembly());

            PrefabManager.Instance.PrefabRegister += RegisterPrefabs;
            PieceManager.Instance.PieceRegister += RegisterPieces;
        }

        private void RegisterPrefabs(object sender, EventArgs e)
        {
            RegisterPrefab("Assets/MoreStacks/BlackMetalBarStack.prefab","BlackMetalBarStack");
            RegisterPrefab("Assets/MoreStacks/CopperBarStack.prefab","CopperBarStack");
            RegisterPrefab("Assets/MoreStacks/IronBarStack.prefab","IronBarStack");
            RegisterPrefab("Assets/MoreStacks/SilverBarStack.prefab","SilverBarStack");
            RegisterPrefab("Assets/MoreStacks/TinBarStack.prefab","TinBarStack");
            RegisterPrefab("Assets/MoreStacks/TreasureChest.prefab","TreasureChest");
            RegisterPrefab("Assets/MoreStacks/FineWoodStack.prefab","FineWoodStack");
            RegisterPrefab("Assets/MoreStacks/CoreWoodStack.prefab","CoreWoodStack");
        }

        private void RegisterPieces(object sender, EventArgs e)
        {
            PieceManager.Instance.RegisterPiece("Hammer", "BlackMetalBarStack");
            PieceManager.Instance.RegisterPiece("Hammer", "CopperBarStack");
            PieceManager.Instance.RegisterPiece("Hammer", "IronBarStack");
            PieceManager.Instance.RegisterPiece("Hammer", "SilverBarStack");
            PieceManager.Instance.RegisterPiece("Hammer", "TinBarStack");
            PieceManager.Instance.RegisterPiece("Hammer", "TreasureChest");
            PieceManager.Instance.RegisterPiece("Hammer", "FineWoodStack");
            PieceManager.Instance.RegisterPiece("Hammer", "CoreWoodStack");
        }


    }
}
