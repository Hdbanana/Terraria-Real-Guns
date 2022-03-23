using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RealGuns.Items
{
    public class Glock34 : ModItem
    {
        private object itemID;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Glock 34");
            Tooltip.SetDefault("Austrian Pistol - 1998");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 40;
            item.height = 40;
            item.useAnimation = 2;
            item.reuseDelay = 14;
            item.shootSpeed = 7f;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 1500;
            item.rare = 1;
            item.UseSound = SoundID.Item41;
            item.autoReuse = false;
            item.useAmmo = AmmoID.Bullet;
            item.noMelee = true;
            item.shoot = ProjectileID.Bullet;
            item.scale = 0.5f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StoneBlock, 30);
            recipe.AddRecipeGroup("IronBar", 15);
            recipe.AddTile(tileID: TileID.Anvils);
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Vector2 perturbedspeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5));
            speedX = perturbedspeed.X;
            speedY = perturbedspeed.Y;
            return base.Shoot(player, ref position, ref speedX, ref speedY, ref type, ref damage, ref knockBack);
        }
    }
}