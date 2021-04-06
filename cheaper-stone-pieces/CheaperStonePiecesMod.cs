using BaraphorSharedLibs;
using BepInEx;
using BepInEx.Configuration;

namespace CheaperStonePieces
{
    [BepInPlugin("com.baraphor.cheaperstonepieces", "Cheaper Stone Pieces", "1.0.0")]
    [BepInProcess("valheim.exe")]
    public class CheaperStonePiecesMod : BaseValheimMod
    {
        public static ConfigEntry<int> stone_wall_4x2;
        public static ConfigEntry<int> stone_wall_2x1;
        public static ConfigEntry<int> stone_wall_1x1;
        public static ConfigEntry<int> stone_floor_2x2;
        public static ConfigEntry<int> stone_arch;
        public static ConfigEntry<int> stone_pillar;
        public static ConfigEntry<int> stone_stair;

        public CheaperStonePiecesMod() : base("com.baraphor.cheaperstonepieces")
        {
            // Constructor Needs some code, otherwise it gets stripped
            stone_wall_4x2 = Config.Bind<int>("StonePieceCosts", "StoneWall4x2", 8, "The cost of the the StoneWall4x2 piece, the unmodded value is 6.");
            stone_wall_2x1 = Config.Bind<int>("StonePieceCosts", "StoneWall2x1", 2, "The cost of the the StoneWall4x2 piece, the unmodded value is 6.");
            stone_wall_1x1 = Config.Bind<int>("StonePieceCosts", "StoneWall1x1", 1, "The cost of the the StoneWall4x2 piece, the unmodded value is 3.");
            stone_floor_2x2 = Config.Bind<int>("StonePieceCosts", "StoneFloor2x2", 4, "The cost of the the StoneWall4x2 piece, the unmodded value is 6.");
            stone_arch = Config.Bind<int>("StonePieceCosts", "StoneArch", 2, "The cost of the the StoneWall4x2 piece, the unmodded value is 4.");
            stone_pillar = Config.Bind<int>("StonePieceCosts", "StonePillar", 2, "The cost of the the StoneWall4x2 piece, the unmodded value is 5.");
            stone_stair = Config.Bind<int>("StonePieceCosts", "StoneStair", 4, "The cost of the the StoneWall4x2 piece, the unmodded value is 8.");

            Logger.LogDebug("Loaded com.baraphor.cheaperstonepieces");
        }

        public void Awake()
        {
            Harmony.PatchAll();

        }
    }
}
