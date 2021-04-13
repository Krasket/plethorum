using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Weapons.Ranged
{
	public class MeteoricBlaze : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("[c/5A3661:Meteoric Blaze]");
			Tooltip.SetDefault("The sabotager of the earth.");
		}

		public override void SetDefaults() {
			item.damage = 49;
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 20; 
			item.useAnimation = 20; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 20; 
			item.value = 6969;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 8f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(ItemID.SoulofNight, 6);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .50f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 6 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(40)); 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

	

	
	}
}