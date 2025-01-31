using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Accessory;

public class BandOfHealingSurge : ModItem
{
    protected override bool CloneNewInstances => false;
    int HealthRecoverDelay = 0;
    const int MaxHealthRecoverDelay = 45 * 60;

    public override void SetDefaults()
    {
        Item.width = 22;
        Item.height = 10;
        Item.maxStack = 1;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 0, 16);
        Item.rare = ItemRarityID.LightPurple;
    }

    public override void UpdateEquip(Player player)
    {
        if (HealthRecoverDelay <= 0)
        {
            if (player.statLife < player.statLifeMax2 * 0.4f)
            {
                player.Heal((int)(MathF.Max(player.statLifeMax2 * 0.4f, 1)));
                HealthRecoverDelay = MaxHealthRecoverDelay;
            }
        }
        else
        {
            HealthRecoverDelay--;
        }
    }
}