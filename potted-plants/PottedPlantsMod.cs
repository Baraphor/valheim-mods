using BaraphorSharedLibs;
using BepInEx;
using JotunnLib.Managers;

using System;
using System.Reflection;

namespace PottedPlants
{
    [BepInPlugin("com.baraphor.pottedplants", "Potted Plants", "1.0.0")]
    [BepInProcess("valheim.exe")]
    [BepInDependency(JotunnLib.JotunnLib.ModGuid)]
    public class PottedPlantsMod : BaseValheimMod
    {
        public PottedPlantsMod() : base("com.baraphor.pottedplants")
        {
            // Constructor Needs some code, otherwise it gets stripped
            Logger.LogDebug("Loaded com.baraphor.pottedplants");
        }

        public void Awake()
        {
            LoadAssetBundle("pottedplants", Assembly.GetExecutingAssembly());

            PrefabManager.Instance.PrefabRegister += RegisterPrefabs;
            PieceManager.Instance.PieceRegister += RegisterPieces;
        }

        private void RegisterPrefabs(object sender, EventArgs e)
        {
            RegisterPrefab("Assets/FlowerPots/YellowFlowerPotPrefab.prefab", "YellowFlowerPot");
            RegisterPrefab("Assets/FlowerPots/BlueFlowerPotPrefab.prefab", "BlueFlowerPot");
            RegisterPrefab("Assets/FlowerPots/RedFlowerPotPrefab.prefab", "RedFlowerPot");
            RegisterPrefab("Assets/FlowerPots/OrangeFlowerPotPrefab.prefab", "OrangeFlowerPot");
            RegisterPrefab("Assets/FlowerPots/WhiteFlowerPotPrefab.prefab", "WhiteFlowerPot");
            RegisterPrefab("Assets/FlowerPots/PurpleFlowerPotPrefab.prefab", "PurpleFlowerPot");
            RegisterPrefab("Assets/FlowerPots/ThistleFlowerPotPrefab.prefab", "ThistleFlowerPot");
        }

        private void RegisterPieces(object sender, EventArgs e)
        {
            PieceManager.Instance.RegisterPiece("Hammer", "YellowFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "BlueFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "RedFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "OrangeFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "WhiteFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "PurpleFlowerPot");
            PieceManager.Instance.RegisterPiece("Hammer", "ThistleFlowerPot");
        }
    }
}
