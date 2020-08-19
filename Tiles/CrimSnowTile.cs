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
    class CrimSnowTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            drop = ModContent.ItemType<CrimSnowItem>();
            AddMapEntry(new Color(255, 184, 179));
            dustType = DustID.Blood;
        }
    }
}
