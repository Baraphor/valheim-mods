using HarmonyLib;
using UnityEngine;

namespace CheaperStonePieces
{
    [HarmonyPatch]
    public class Patch
    {
        [HarmonyPostfix]
        [HarmonyPatch(typeof(ObjectDB), "Awake")]
        public static void PieceTable_Awake_WallCost(ref ObjectDB __instance)
        {
            UnityEngine.Object[] array = UnityEngine.Resources.FindObjectsOfTypeAll(typeof(GameObject));
            for (int i = 0; i < array.Length; i++)
            {
                GameObject gameObject = (GameObject)array[i];

                if (gameObject.name == "stone_wall_4x2")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_wall_4x2.Value;
                }
                else if (gameObject.name == "stone_wall_2x1")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_wall_2x1.Value;
                }
                else if (gameObject.name == "stone_wall_1x1")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_wall_1x1.Value;
                }
                else if (gameObject.name == "stone_floor_2x2")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_floor_2x2.Value;
                }
                else if (gameObject.name == "stone_arch")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_arch.Value;
                }
                else if (gameObject.name == "stone_pillar")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_pillar.Value;
                }
                else if (gameObject.name == "stone_stair")
                {
                    Piece p = gameObject.GetComponent<Piece>();
                    p.m_resources[0].m_amount = CheaperStonePiecesMod.stone_stair.Value;
                }
            }
        }
    }
}
