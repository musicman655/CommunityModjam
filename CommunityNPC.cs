using Terraria.ID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using CommunityModJam.Tiles;

namespace CommunityModJam
{
    class CommunityNPC : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if(npc.type == NPCID.TheDestroyer || npc.type == NPCID.Spazmatism || npc.type == NPCID.Retinazer || npc.type == NPCID.SkeletronPrime)
            {
                if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
                {
                    if (!CommunityWorld.spawnIceOre)
                    {
                        Main.NewText("Icy crystals are growing in the arctic tundra", 122, 251, 255);
                        for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 40E-05); k++)
                        {
                            int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                            int Y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY - 200);
                            Tile tile = Framing.GetTileSafely(X, Y);
                            if (tile.active() && tile.type == TileID.IceBlock || tile.type == TileID.FleshIce || tile.type == TileID.CorruptIce || tile.type == TileID.HallowedIce)
                            {
                                WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(5, 9), WorldGen.genRand.Next(3, 6), (ushort)ModContent.TileType<IceOreTile>());
                            }
                        }
                        CommunityWorld.spawnIceOre = true;
                    }
                    if(!CommunityWorld.spawnHellOre)
                    {
                        Main.NewText("Magma is solidifying in the ashes of hell", 186, 24, 32);
                        for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 10E-05); k++)
                        {
                            int X = WorldGen.genRand.Next(0, Main.maxTilesX);
                            int Y = WorldGen.genRand.Next(Main.maxTilesY - 200, Main.maxTilesY);
                            Tile tile = Framing.GetTileSafely(X, Y);
                            if (tile.active() && tile.type == TileID.Ash)
                            {
                                WorldGen.OreRunner(X, Y, WorldGen.genRand.Next(5, 9), WorldGen.genRand.Next(3, 6), (ushort)ModContent.TileType<HellOreTile>());
                            }
                        }
                        CommunityWorld.spawnHellOre = true;
                    }
                }
            }
        }
    }
}
