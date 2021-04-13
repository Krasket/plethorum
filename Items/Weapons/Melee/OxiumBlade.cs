using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Plethorum.Items.Bars;

namespace Plethorum.Items.Weapons.Melee
{
	public class OxiumBlade : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A sword of super-hot fury.\nInflicts the 'Burning' debuff.");
		}

		public override void SetDefaults() {
			item.damage = 80;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.knockBack = 1;
			item.value = Item.buyPrice(gold: 10);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.crit = 25;
			
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
			if (Main.rand.NextBool(5)) {
				target.AddBuff(BuffID.Burning, 360, false);
			}
		}
	}
}