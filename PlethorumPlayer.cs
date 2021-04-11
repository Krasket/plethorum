using Plethorum.Items.Misc;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Plethorum
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in Plethorum. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class PlethorumPlayer : ModPlayer
	{
		public const int maxPositivity = 1;
		public int Positivity;

		public override void ResetEffects() {
			player.statLifeMax2 += Positivity * 2;
		}

		public override void clientClone(ModPlayer clientClone) {
			PlethorumPlayer clone = clientClone as PlethorumPlayer;
		}

		public override void Load(TagCompound tag) {
			Positivity = tag.GetInt("Positivity");
		}
    }
}