using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace CommunityModJam.MainFiles
{
    class CommunityWorld : ModWorld
    {

		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {

            
            
            int beachGen = tasks.FindIndex(genpass => genpass.Name.Equals("Beaches"));
			if (beachGen != -1)
            {
				tasks[beachGen] = new PassLegacy("Calamity Bad", delegate (GenerationProgress progress)
				{
					progress.Message = "Sans AAAAAAAAAAAAHHHHHHHHH!!!!!";
					LavaOcean();
				});
			}
           
        }

        


       public void LavaOcean()
        {
			int num462 = 0;
			int num463 = 0;
			int num464 = 20;
			int num465 = Main.maxTilesX - 20;
			int dungeonX = Main.dungeonX;
			int dungeonY = Main.dungeonY;
			for (int num466 = 0; num466 < 2; num466++)
			{
				int num467 = 0;
				int num468 = 0;
				int hell = 0;
				if (num466 == 0)
				{
					num467 = 0;
					num468 = WorldGen.genRand.Next(125, 200) + 50;
					if (dungeonX < 100)
					{
						num468 = 275;
					}
					int num469 = 0;
					float num470 = 1f;
					int num471;
					for (num471 = 0; !Main.tile[num468 - 1, num471].active(); num471++)
					{
					}
					num462 = num471;
					num471 += WorldGen.genRand.Next(1, 5);
					for (int num472 = num468 - 1; num472 >= num467; num472--)
					{
						num469++;
						if (num469 < 3)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.2f;
						}
						else if (num469 < 6)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.15f;
						}
						else if (num469 < 9)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.1f;
						}
						else if (num469 < 15)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.07f;
						}
						else if (num469 < 50)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num469 < 75)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.04f;
						}
						else if (num469 < 100)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.03f;
						}
						else if (num469 < 125)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.02f;
						}
						else if (num469 < 150)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						else if (num469 < 175)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.005f;
						}
						else if (num469 < 200)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.001f;
						}
						else if (num469 < 230)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						else if (num469 < 235)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num469 < 240)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.1f;
						}
						else if (num469 < 245)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num469 < 255)
						{
							num470 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						if (num469 == 235)
						{
							num465 = num472;
						}
						if (num469 == 235)
						{
							num464 = num472;
						}
						int num473 = WorldGen.genRand.Next(15, 20);
						for (int num474 = 0; (float)num474 < (float)num471 + num470 + (float)num473; num474++)
						{
							if ((float)num474 < (float)num471 + num470 * 0.75f - 3f)
							{
								Main.tile[num472, num474].active(active: false);
								if (num474 > num471)
								{
									Main.tile[num472, num474].liquid = byte.MaxValue;
									Main.tile[num472, num474].lava(true);
								}
								else if (num474 == num471)
								{
									Main.tile[num472, num474].liquid = 127;
									Main.tile[num472, num474].lava(true);
								}
							}
							else if (num474 > num471)
							{
								Main.tile[num472, num474].type = 57;
								Main.tile[num472, num474].active(active: true);
							}
							Main.tile[num472, num474].wall = 0;
						}
					}
				}
				else
				{
					num467 = Main.maxTilesX - WorldGen.genRand.Next(125, 200) - 50;
					num468 = Main.maxTilesX;

					if (dungeonX > 100)
					{
						num467 = Main.maxTilesX - 275;
					}
					float num475 = 1f;
					int num476 = 0;
					int num477;
					for (num477 = 0; !Main.tile[num467, num477].active(); num477++)
					{
					}
					num463 = num477;
					num477 += WorldGen.genRand.Next(1, 5);
					for (int num478 = num467; num478 < num468; num478++)
					{
						num476++;
						if (num476 < 3)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.2f;
						}
						else if (num476 < 6)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.15f;
						}
						else if (num476 < 9)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.1f;
						}
						else if (num476 < 15)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.07f;
						}
						else if (num476 < 50)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num476 < 75)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.04f;
						}
						else if (num476 < 100)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.03f;
						}
						else if (num476 < 125)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.02f;
						}
						else if (num476 < 150)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						else if (num476 < 175)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.005f;
						}
						else if (num476 < 200)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.001f;
						}
						else if (num476 < 230)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						else if (num476 < 235)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num476 < 240)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.1f;
						}
						else if (num476 < 245)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.05f;
						}
						else if (num476 < 255)
						{
							num475 += (float)WorldGen.genRand.Next(10, 20) * 0.01f;
						}
						if (num476 == 235)
						{
							num465 = num478;
						}
						int num479 = WorldGen.genRand.Next(15, 20);
						for (int num480 = 0; (float)num480 < (float)num477 + num475 + (float)num479; num480++)
						{
							if ((float)num480 < (float)num477 + num475 * 0.75f - 3f && (double)num480 < Main.worldSurface - 2.0)
							{
								Main.tile[num478, num480].active(active: false);
								if (num480 > num477)
								{
									Main.tile[num478, num480].liquid = byte.MaxValue;
									Main.tile[num478, num480].lava(true);
								}
								else if (num480 == num477)
								{
									Main.tile[num478, num480].liquid = 127;
									Main.tile[num478, num480].lava(true);
								}
							}
							else if (num480 > num477)
							{
								Main.tile[num478, num480].type = 57;
								Main.tile[num478, num480].active(active: true);
							}
							Main.tile[num478, num480].wall = 0;
						}
					}
				}
			}
			for (; !Main.tile[num464, num462].active(); num462++)
			{
			}
			num462++;
			for (; !Main.tile[num465, num463].active(); num463++)
			{
			}
			num463++;
		}









    }
}
		