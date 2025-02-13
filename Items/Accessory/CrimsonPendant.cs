using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Accessory;

public class CrimsonPendant : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 17;
        Item.height = 20;
        Item.maxStack = 1;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 0, 40);
        Item.rare = ItemRarityID.LightRed;
    }

    const float IncreaseDamage = .07f;
    const int IncreaseCritRate = 4, Defense = 2;

    public override void UpdateEquip(Player player)
    {
        player.GetDamage<MeleeDamageClass>() += IncreaseDamage;
        player.GetCritChance<MeleeDamageClass>() += IncreaseCritRate;
        player.GetDamage<SummonDamageClass>() += IncreaseDamage;
        player.GetCritChance<SummonDamageClass>() += IncreaseCritRate;
        player.statDefense += Defense;
    }
}