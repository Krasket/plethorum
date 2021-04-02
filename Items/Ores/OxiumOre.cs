using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Items.Ores
{
	public class OxiumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A mineral of extreme heat, said to have tricked many unsuspecting miners in the old days.");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 68;
		}

		public override void SetDefaults()
		{   
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 10;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.OxiumOre>();
			item.width = 12;
			item.height = 12;
			item.value = 150;
		}
	}
}