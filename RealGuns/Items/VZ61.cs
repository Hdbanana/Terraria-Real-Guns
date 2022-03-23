using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class VZ61 : ModItem
	{
        private object itemID;

        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("vz. 61");
			Tooltip.SetDefault("Czechoslovakian Machine Pistol - 1959");
		}

		public override void SetDefaults() {
			item.damage = 3;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 5;
			item.shootSpeed = 6f;
            item.useStyle = 5;
            item.knockBack = 2;
			item.value = 5000;
			item.rare = 2;
            item.UseSound = SoundID.Item40;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.noMelee = true;
			item.shoot = ProjectileID.Bullet;
			item.scale = 0.7f;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 20);
			recipe.AddIngredient(ItemID.Wood, 50);
			recipe.AddTile(tileID: TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			Vector2 perturbedspeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(11));
			speedX = perturbedspeed.X;
			speedY = perturbedspeed.Y;
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(7, 1);
			return base.HoldoutOffset();
		}
	}
}