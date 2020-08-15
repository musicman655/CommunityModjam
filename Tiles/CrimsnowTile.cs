using Terraria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using CommunityModJam.Items.Placables;
using Microsoft.Xna.Framework;
using Terraria.ID;

namespace CommunityModJam.Tiles
{
    class CrimsnowTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            drop = ModContent.ItemType<Crimsnow>();
            AddMapEntry(new Color(255, 184, 179));
            dustType = DustID.Blood;
        }
    }
}
