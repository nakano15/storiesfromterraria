using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Weapons;

public class GrenadesBundle : ModItem
{
    public override void SetDefaults()
    {
        Item.useStyle = ItemUseStyleID.Swing;
        Item.shootSpeed = 14f;
        Item.shoot = ProjectileID.Grenade;
        Item.damage = 50;
        Item.knockBack = 8;
        Item.crit = 4;
        Item.DamageType = DamageClass.Ranged;
        Item.useAmmo = ItemID.Grenade;
        Item.width = 66;
        Item.height = 66;
        Item.maxStack = 1;
        Item.useAnimation = 20;
        Item.useTime = 50;
        Item.noUseGraphic = true;
        Item.noMelee = true;
        Item.value = Item.buyPrice(0, 0, 60);
        Item.rare = ItemRarityID.Blue;
    }

    public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
    {
        Vector2 PlayerCenter = position;
        Vector2 AimPosition = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
        float[] Rotations = [MathF.Atan2(-velocity.Y, velocity.X) + MathHelper.ToRadians(90f), 0, 0, 0, 0];
        Rotations[1] = Rotations[0] - MathHelper.ToRadians(-Main.rand.NextFloat(5f, 15f));
        Rotations[2] = Rotations[0] - MathHelper.ToRadians(Main.rand.NextFloat(5f, 15f));
        Rotations[3] = Rotations[0] - MathHelper.ToRadians(-Main.rand.NextFloat(10f, 20f));
        Rotations[4] = Rotations[0] - MathHelper.ToRadians(Main.rand.NextFloat(10f, 20f));
        float ExtraChance = 1f;
        foreach (float Rotation in Rotations)
        {
            if (Main.rand.NextFloat() < ExtraChance)
            {
                float Speed = Item.shootSpeed * Main.rand.NextFloat(.9f, 1.1f);
                velocity.X = MathF.Sin(Rotation) * Speed;
                velocity.Y = MathF.Cos(Rotation) * Speed;
                Projectile.NewProjectile(source, PlayerCenter, velocity, type, damage, knockback, player.whoAmI);
                ExtraChance -= .1f;
            }
        }
        return false;
    }
}