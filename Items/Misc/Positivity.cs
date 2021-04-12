using Microsoft.Xna.Framework;
using Terraria;
using Plethorum.Items.Bars;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Misc
{
	// Making an item like Life Fruit (That goes above 500) involves a lot of code, as there are many things to consider. (An alternate that approaches 500 can simply follow vanilla code, however.):
	//    You can't make player.statLifeMax more than 500 (it won't save), so you'll have to maintain your extra life within your mod.
	//    Within your ModPlayer, you need to save/load a count of usages. You also need to sync the data to other players. 
	internal class Positivity : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Permanently increases maximum life by 200");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.LifeFruit);
			item.color = Color.Purple;
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
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
            recipe.AddIngredient(ItemID.SpectreBar, 5);
            recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddIngredient(ItemID.LifeCrystal, 5);
            recipe.AddIngredient(ItemID.LifeFruit, 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}