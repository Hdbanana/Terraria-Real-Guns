using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class M134 : ModItem
	{
		private object itemID;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("M134");
			Tooltip.SetDefault("American Rotary Machinegun - 1960");
		}

		public override void SetDefaults()
		{
			item.damage = 75;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.shootSpeed = 10f;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 750000;
			item.rare = 11;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.noMelee = true;
			item.shoot = ProjectileID.Bullet;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 50);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddTile(tileID: TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(5, 10);
			return base.HoldoutOffset();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(0);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15));
																											
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
			
		}
	
        public override bool ConsumeAmmo(Player player) => Main.rand.NextFloat() >= .40f;
    }
}