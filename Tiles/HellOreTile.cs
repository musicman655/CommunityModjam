
using CommunityModjam.Items.Placeables;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CommunityModjam.Tiles
{
    class HellOreTile : ModTile
    {
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 410;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Elyrium Ore");
			AddMapEntry(new Color(186, 24, 32), name);

			dustType = 84;
			drop = ModContent.ItemType<HellOreItem>();
			soundType = SoundID.Tink;
			soundStyle = 1;
			mineResist = 5f;
			minPick = 200;
		}
	}
}
