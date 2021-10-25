using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class MP5A3 : ModItem
	{
        private object itemID;

        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("MP5A3");
			Tooltip.SetDefault("German Submachine gun - 1966");
		}

		public override void SetDefaults() {
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 7;
			item.useAnimation = 7;
			item.shootSpeed = 8;
            item.useStyle = 5;
            item.knockBack = 3;
			item.value = 50000;
			item.rare = 4;
            item.UseSound = SoundID.Item31;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.noMelee = true;
			item.shoot = ProjectileID.Bullet;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddIngredient(ItemID.MeteoriteBar, 10);
			recipe.AddTile(tileID: TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 perturbedspeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(7));
			speedX = perturbedspeed.X;
			speedY = perturbedspeed.Y;
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-7, 0);
			return base.HoldoutOffset();
		}
	}
}