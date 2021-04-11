using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Plethorum.Projectiles
{
	public class OxiumDrill : ModProjectile
	{
		public override void SetDefaults() {
			projectile.width = 18;
			projectile.height = 50;
			projectile.aiStyle = 20;
			projectile.friendly = true;
			projectile.penetrate = -10;
			projectile.tileCollide = false;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
		}

		public override void AI() {
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1.9f);
			Main.dust[dust].noGravity = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			if (Main.rand.NextBool(10)) {
				target.AddBuff(BuffID.Burning, 180, false);
			}
		}

		public override void OnHitPvp(Player target, int damage, bool crit) {
			if (Main.rand.NextBool(10)) {
				target.AddBuff(BuffID.OnFire, 180, false);
			}
		}
	}
}