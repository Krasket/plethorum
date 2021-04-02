using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Lore
{
	public class FirstLore : ModItem
	{
		public override void SetStaticDefaults() {
            DisplayName.SetDefault("The Kindly One");
			Tooltip.SetDefault("The Kindly One watches you from the heavens.");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 20;
			item.maxStack = 1;
			item.value = 1000;
			item.rare = ItemRarityID.Expert;
		}
	}
}