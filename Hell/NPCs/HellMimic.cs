using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Audio;
using static Terraria.ModLoader.ModContent;

namespace CommunityModjam.Hell.NPCs
{
	public class HellMimic : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell Mimic");
			NPCID.Sets.MustAlwaysDraw[npc.type] = true;
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BigMimicCorruption];
		}

		public override void SetDefaults()
		{
			npc.width = 28;
			npc.height = 44;
			npc.aiStyle = 87;
			npc.damage = 90;
			npc.defense = 34;
			npc.lifeMax = 3500;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 30000f;
			npc.knockBackResist = 0.1f;
			npc.buffImmune[20] = true;
			npc.buffImmune[24] = true;
			npc.buffImmune[39] = true;
			npc.rarity = 5;
		}
		public override void AI()
		{
			//npc.CloneDefaults(NPCID.BigMimicJungle);
		}
	}
}

//Let the hell begin