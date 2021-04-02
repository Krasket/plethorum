using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Plethorum.Items.Bars;

namespace Plethorum.Items.Weapons.Melee
{
	public class OxiumBlade : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A sword of super-hot fury.\nInflicts the 'Burning' debuff.");
		}

		public override void SetDefaults() {
			item.damage = 89;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 4;
			item.value = Item.buyPrice(gold: 10);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 50;
			
			//Use useStyle 1 for normal swinging or for throwing
			//use useStyle 2 for an item that drinks such as a potion,
			//use useStyle 3 to make the sword act like a shortsword
			//use useStyle 4 for use like a life crystal,
			//and use useStyle 5 for staffs or guns
			item.useStyle = ItemUseStyleID.SwingThrow;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<OxiumBar>(), 6);
			recipe.AddIngredient(ItemID.FieryGreatsword);
			recipe.AddRecipeGroup("Plethorum:AdamantiteTitanium", 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Burning, 240);
		}
	}
}