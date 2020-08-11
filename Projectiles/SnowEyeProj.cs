using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ModJam.Projectiles
{
    class SnowEyeProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aurora Beam");
        }

        public override void SetDefaults()
        {
            projectile.width = 26;
            projectile.height = 44;
            projectile.hostile = true;
            aiType = 1;
            projectile.ignoreWater = true;
            projectile.tileCollide = true;
            projectile.timeLeft = 300;
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            if (Main.rand.NextFloat() < 0.5f)
            {
                Dust dust;
                Vector2 position = projectile.Center;
                dust = Main.dust[Terraria.Dust.NewDust(position, 10, 10, 15, 0f, 0f, 255, new Color(0, 242, 255), 1f)];
            }
        }
        public override void Kill(int timeLeft)
        {
            Dust dust;
            Dust dust1;
            Dust dust2;
            Vector2 position = projectile.Center;
            dust = Main.dust[Terraria.Dust.NewDust(position, 10, 10, 15, 0f, 0f, 255, new Color(0, 255, 192), 1f)];
            dust.fadeIn = 1.026316f;
            dust1 = Main.dust[Terraria.Dust.NewDust(position, 10, 10, 15, 0f, 0f, 255, new Color(0, 255, 192), 1f)];
            dust1.fadeIn = 1.026316f;
            dust2 = Main.dust[Terraria.Dust.NewDust(position, 10, 10, 15, 0f, 0f, 255, new Color(0, 255, 192), 1f)];
            dust2.fadeIn = 1.026316f;

        }
    }
}
