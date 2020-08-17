using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.IO;
using static Terraria.ModLoader.ModContent;
using Terraria.Audio;

namespace CommunityModjam.Hell.NPCs
{
	class HellMimic : ModNPC
	{
		public override void SetStaticDefaults()
		{
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[475];
		}
		public override void SetDefaults()
		{
			npc.CloneDefaults(475);
			aiType = 475;
			animationType = 475;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (spawnInfo.player.ZoneUnderworldHeight && Main.hardMode && !NPC.AnyNPCs(NPCType<HellMimic>()))
			{
				return .0075f;
			}
			else
			{ 
				return 0f;
			}
				
		}
	}
}