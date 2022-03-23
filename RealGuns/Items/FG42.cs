using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
	public class FG42 : ModItem
	{
        private object itemID;

        public override void SetStaticDefaults() 
		{
		    DisplayName.SetDefault("FG42");
			Tooltip.SetDefault("German Paratroop Rifle - 1942");
		}

		public override void SetDefaults() 
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 6;
			item.useAnimation = 6;
			item.shootSpeed = 10f;
            item.useStyle = 5;
            item.knockBack = 6;
			item.value = 100000;
			item.rare = 5;
            item.UseSound = SoundID.Item31;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.noMelee = true;
			item.shoot = ProjectileID.Bullet;
			item.scale = 1.3f;
			item.crit = 8;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddTile(tileID: TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

			recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 10);
			recipe.AddIngredient(ItemID.Wood, 30);
			recipe.AddIngredient(ItemID.AdamantiteBar, 10);
			recipe.AddTile(tileID: TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
        {
			return new Vector2(-9, -5);
            return base.HoldoutOffset();
        }

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedspeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3));
			speedX = perturbedspeed.X;
			speedY = perturbedspeed.Y;
			return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
		}
	}
}