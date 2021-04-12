using Plethorum.Projectiles;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Weapons.Magic
{
	public class CosmicLightShard : ModItem
	{
		public static Color OverrideColor = new Color(203, 130, 255);
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A large fragment of intense, blinding light.");
		}

		public override void SetDefaults()
		{
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
			item.CloneDefaults(ItemID.LastPrism);
			item.value = 300000;
			item.magic = true;
			item.width = 24;
			item.height = 32;
			item.mana = 2;
			item.rare = ItemRarityID.Expert;
			if (calamityMod != null)
			{
				item.damage = 15000;
			}
			else
			{
				item.damage = 1000;
			}
			item.shoot = ModContent.ProjectileType<CosmicLightShardHoldout>();
			item.shootSpeed = 7f;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            Mod calamityMod = ModLoader.GetMod("CalamityMod");
            if (calamityMod != null)
            {
				recipe.AddIngredient(calamityMod.ItemType("ShadowspecBar"), 15);
				recipe.AddIngredient(calamityMod.ItemType("YharimsCrystal"), 1);
                recipe.AddIngredient(calamityMod.ItemType("GalacticaSingularity"), 5);
                recipe.AddTile(calamityMod.TileType("DraedonsForge"));
            }
            else
            {
                recipe.AddIngredient(ItemID.FragmentNebula, 5);
                recipe.AddIngredient(ItemID.FragmentSolar, 5);
                recipe.AddIngredient(ItemID.FragmentVortex, 5);
                recipe.AddIngredient(ItemID.FragmentStardust, 5);
                recipe.AddIngredient(ItemID.LunarBar, 20);
                recipe.AddIngredient(ItemID.LastPrism, 1);
                recipe.AddTile(TileID.LunarCraftingStation);
            }
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool CanUseItem(Player player) => player.ownedProjectileCounts[ModContent.ProjectileType<CosmicLightShardHoldout>()] <= 0;
	}
}