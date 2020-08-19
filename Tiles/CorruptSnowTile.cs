using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.ID;
using CommunityModJam.Items.Placeables;

namespace CommunityModJam.Tiles
{
    class CorruptSnowTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            drop = ModContent.ItemType<CorruptSnowItem>();
            AddMapEntry(new Color(228, 181, 255));
            dustType = DustID.ToxicBubble;
        }
    }
}

