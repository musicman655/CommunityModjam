using Microsoft.Xna.Framework;
using CommunityModjam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CommunityModJam.Projectiles.Hostile;

namespace CommunityModJam.NPCs.Hostile
{
    class SnowEye : ModNPC
    {
        private int frameNum = 0;
        private int frameTimer = 0;
        private int shootTimer = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Aurora Apparition");
            Main.npcFrameCount[npc.type] = 2;
        }
        public override void SetDefaults()
        {
            npc.width = 52;
            npc.height = 60;

            npc.aiStyle = NPCID.DemonEye;

            npc.lifeMax = 300;
            npc.damage = 40;
            npc.defense = 20;
            npc.knockBackResist = 0.2f;
            npc.value = 1500;

            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
        }
        public override void AI()
        {
            Player player = Main.player[npc.target];
            Vector2 target = npc.HasPlayerTarget ? player.Center : Main.npc[npc.target].Center;
            Vector2 npcRotationCalc = new Vector2(npc.position.X + npc.width * 0.5f, npc.position.Y + npc.height * 0.5f);
            float playerX = Main.player[npc.target].position.X + (Main.player[npc.target].width / 2) - npcRotationCalc.X;
            float playerY = Main.player[npc.target].position.Y + (Main.player[npc.target].height / 2) - npcRotationCalc.Y;
            if (playerX > 0f)
            {
                npc.spriteDirection = player.direction;
                npc.rotation = (float)Math.Atan2(playerX, -playerY) + 3.14f;
            }
            if (playerX < 0f)
            {
                npc.spriteDirection = -player.direction;
                npc.rotation = (float)Math.Atan2(playerX, -playerY) + -3.14f;

            }
            Vector2 shootPos = npc.Center;
            float accuracy = 5f * (npc.life / npc.lifeMax);
            Vector2 shootVel = target - shootPos + new Vector2(Main.rand.NextFloat(-accuracy, accuracy), Main.rand.NextFloat(-accuracy, accuracy));
            shootVel.Normalize();
            shootVel *= 14.5f;
            shootTimer++;
            if (shootTimer>= 60)
            {
                Projectile.NewProjectile(shootPos.X + (float)Main.rand.Next(-20, 20), shootPos.Y + (float)Main.rand.Next(-20, 20), shootVel.X, shootVel.Y, ModContent.ProjectileType<SnowEyeProj>(), 40, 5f);
                shootTimer = 0;
            }
            frameTimer++;
        }
            
        public override void FindFrame(int frameHeight)
        {
            if (frameTimer == 6)
            {
                frameNum++;
                frameTimer = 0;
            }

            if (frameNum == 2)
            {
                frameNum = 0;
            }

            npc.frame.Y = frameNum * frameHeight;
        }
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, Main.expertMode ? 180 : 120, false);
        }
        public override void HitEffect(int hitDirection, double damage)
        {
            if (Main.rand.NextFloat() < 0.8f)
            {
                Dust dust;
                Vector2 position = npc.Center;
                dust = Main.dust[Terraria.Dust.NewDust(position, 10, 10, 15, 0f, 0f, 255, new Color(0, 92, 255), 1f)];
                dust.fadeIn = 1.026316f;
            }

        }
    }
}
