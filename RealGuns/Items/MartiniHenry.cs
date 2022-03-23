using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class MartiniHenry : ModItem
	{
		private object itemID;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martini Henry");
			Tooltip.SetDefault("British Lever Action - 1870");
		}

		public override void SetDefaults()
		{
			item.damage = 275;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.shootSpeed = 30f;
			item.useTime = 75;
			item.useAnimation = 75;
			item.useStyle = 5;
			item.knockBack = 8;
			item.value = 450000;
			item.rare = 10;
			item.UseSound = SoundID.Item40;
			item.autoReuse = false;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = ProjectileID.BulletHighVelocity;
			item.noMelee = true;
			item.scale = 1.8f;
			item.crit = 24;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 10);
			recipe.AddIngredient(ItemID.SniperRifle);
			recipe.AddTile(tileID: TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-7, 2);
			return base.HoldoutOffset();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (type == ProjectileID.Bullet)
            {
				type = ProjectileID.BulletHighVelocity;
            }
			return true;
		}

	}
}