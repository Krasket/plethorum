using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Plethorum.Items.Bars;
using Terraria.ModLoader;

namespace Plethorum.Items
{
	public class OxiumHammer : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A hammer worthy of Thor.");
		}

		public override void SetDefaults() {
			item.damage = 48;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.hammer = 210;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 20;
			item.value = 5000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<OxiumBar>(), 4);
			recipe.AddRecipeGroup("Plethorum:AdamantiteTitanium", 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}