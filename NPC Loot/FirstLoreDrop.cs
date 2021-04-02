using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Plethorum.Items.Lore;

namespace Plethorum
{
    public class FirstLoreDrop : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            if (Main.rand.Next(100) == 0)
            {
                if (npc.type == NPCID.EyeofCthulhu)
                {
                    Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FirstLore>());
                }
            }
        }
    }
}