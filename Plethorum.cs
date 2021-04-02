using Terraria.ModLoader;
using Terraria;
using Terraria.Localization;
using Terraria.ID;

namespace Plethorum
{
	public class Plethorum : Mod
	{
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Adamantite Titanium", new int[]
			{
				ItemID.TitaniumBar,
				ItemID.AdamantiteBar
			});
			RecipeGroup.RegisterGroup("Plethorum:AdamantiteTitanium", group);

			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron Lead", new int[]
			{
				ItemID.IronBar,
				ItemID.LeadBar
			});
			RecipeGroup.RegisterGroup("Plethorum:IronLead", group);
		}
	}
}