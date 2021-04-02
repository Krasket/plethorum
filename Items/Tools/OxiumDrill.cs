using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items
{
	public class OxiumDrill : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Legends say that it can destroy a world in a blink of the eye.");
		}

		public override void SetDefaults() {
			item.damage = 38;
			item.melee = true;
			item.width = 50;
			item.height = 18;
			item.useTime = 2;
			item.useAnimation = 15;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 210;
			item.tileBoost++;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = Item.buyPrice(gold: 5);
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.OxiumDrill>();
			item.shootSpeed = 10f;
		}
	}
}