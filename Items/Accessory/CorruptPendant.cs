using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Accessory;

public class CorruptPendant : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 17;
        Item.height = 22;
        Item.maxStack = 1;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 0, 40);
        Item.rare = ItemRarityID.Orange;
    }

    const float IncreaseDamage = .07f, AttackSpeed = .06f;
    const int IncreaseCritRate = 4;

    public override void UpdateEquip(Player player)
    {
        player.GetDamage<MagicDamageClass>() += IncreaseDamage;
        player.GetCritChance<MagicDamageClass>() += IncreaseCritRate;
        player.GetDamage<RangedDamageClass>() += IncreaseDamage;
        player.GetCritChance<RangedDamageClass>() += IncreaseCritRate;
        player.GetAttackSpeed<MeleeDamageClass>() += AttackSpeed;
    }
}