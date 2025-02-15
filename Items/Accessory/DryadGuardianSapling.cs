using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Accessory;

public class DryadGuardianSapling : ModItem
{
    protected override bool CloneNewInstances => false;
    int LastItemTime = 0;
    const float LeafSpeed = 14f;
    const int LeafDamage = 14;

    public override void SetDefaults()
    {
        Item.width = 10;
        Item.height = 13;
        Item.maxStack = 1;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 0, 30);
        Item.rare = ItemRarityID.Orange;
    }

    public override void UpdateEquip(Player player)
    {
        if (player.itemTime > 1 && LastItemTime <= 1 && Main.rand.NextFloat() < 0.3f)
        {
            Vector2 SpawnPosition = player.MountedCenter;
            Vector2 ShotDirection = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY) - SpawnPosition;
            ShotDirection.Normalize();
            float Rotation = -MathF.Atan2(ShotDirection.Y, ShotDirection.X) + MathHelper.ToRadians(90f);
            int Leaves = Main.rand.Next(3, 6);
            float RadiansVariant = MathHelper.ToRadians(30f / Leaves);
            Rotation -= RadiansVariant;
            for (int l = 0; l < Leaves; l++)
            {
                ShotDirection.X = MathF.Sin(Rotation) * LeafSpeed;
                ShotDirection.Y = MathF.Cos(Rotation) * LeafSpeed;
                int p = Projectile.NewProjectile(Item.GetSource_ReleaseEntity(), SpawnPosition, ShotDirection, ProjectileID.Leaf, LeafDamage, 0f, player.whoAmI);
                Main.projectile[p].penetrate = Main.projectile[p].maxPenetrate = 5;
                Rotation += RadiansVariant;
            }
        }
        LastItemTime = player.itemTime;
        player.lifeRegen += 3;
    }
}