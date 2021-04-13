using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Misc
{
	internal class Positivity : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Permanently increases maximum life by 50\nCan only be used once");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.LifeFruit);
			item.color = Color.Red;
		}

		public override bool CanUseItem(Player player) {
			return player.statLifeMax == 500 && player.GetModPlayer<PlethorumPlayer>().Positivity < PlethorumPlayer.maxPositivity;
		}

		public override bool UseItem(Player player) {
			player.statLifeMax2 += 50;
			player.statLife += 50;
			if (Main.myPlayer == player.whoAmI) {
				player.HealEffect(50, true);
			}
			player.GetModPlayer<PlethorumPlayer>().Positivity += 1;
			return true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddIngredient(ItemID.GlowingMushroom, 5);
            recipe.AddIngredient(ItemID.LifeFruit, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}