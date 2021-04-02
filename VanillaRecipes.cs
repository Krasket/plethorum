using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.ID;

namespace Plethorum
{
	public class Recipes : ModItem
	{
        public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Plethorum:IronLead", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ClimbingClaws);
			recipe.AddRecipe();

            recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Plethorum:IronLead", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.ShoeSpikes);
			recipe.AddRecipe();
		}
	}
}