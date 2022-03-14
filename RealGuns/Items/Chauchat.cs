using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class Chauchat : ModItem
	{
		private object itemID;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chauchat");
			Tooltip.SetDefault("French Automatic Rifle - 1907");
		}

		public override void SetDefaults()
		{
			item.damage = 75;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 16;
			item.shootSpeed = 15f;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 200000;
			item.rare = 8;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.noMelee = true;
			item.shoot = ProjectileID.Bullet;
			item.scale = 1.5f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ShroomiteBar, 20);
			recipe.AddIngredient(ItemID.VenusMagnum);
			recipe.AddTile(tileID: TileID.Autohammer);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, -3);
			return base.HoldoutOffset();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedspeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(2));
			speedX = perturbedspeed.X;
			speedY = perturbedspeed.Y;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}