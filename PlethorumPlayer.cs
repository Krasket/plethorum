using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Plethorum
{
	public class PlethorumPlayer : ModPlayer
	{
		public const int maxPositivity = 1;
		public int Positivity;

		public override void ResetEffects() {
			player.statLifeMax2 += Positivity * 50;
		}

		public override void clientClone(ModPlayer clientClone) {
			PlethorumPlayer clone = clientClone as PlethorumPlayer;
		}

		public override void Load(TagCompound tag) {
			Positivity = tag.GetInt("Positivity");
		}
    }
}