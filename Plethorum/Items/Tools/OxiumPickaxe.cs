using Microsoft.Xna.Framework;
using Plethorum.Items.Bars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Tools
{
	public class OxiumPickaxe : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Said to have an edge of incineration steel.");
		}
		public override void SetDefaults() {
			item.damage = 27;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.pick = 210;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 1;
			item.value = 4000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<OxiumBar>(), 6);
			recipe.AddRecipeGroup("Plethorum:AdamantiteTitanium", 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			
			target.AddBuff(BuffID.OnFire, 120);
		}
	}
}