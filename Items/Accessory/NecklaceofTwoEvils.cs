using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Items.Accessory;

public class NecklaceofTwoEvils : ModItem
{
    public override void SetDefaults()
    {
        Item.width = 26;
        Item.height = 22;
        Item.maxStack = 1;
        Item.accessory = true;
        Item.value = Item.sellPrice(0, 1, 20);
        Item.rare = ItemRarityID.Pink;
    }

    const float IncreaseDamage = .07f, AttackSpeed = .06f;
    const int IncreaseCritRate = 4, Defense = 2;

    public override void UpdateEquip(Player player)
    {
        player.GetDamage<MagicDamageClass>() += IncreaseDamage;
        player.GetCritChance<MagicDamageClass>() += IncreaseCritRate;
        player.GetDamage<RangedDamageClass>() += IncreaseDamage;
        player.GetCritChance<RangedDamageClass>() += IncreaseCritRate;
        player.GetAttackSpeed<MeleeDamageClass>() += AttackSpeed;
        player.GetDamage<MeleeDamageClass>() += IncreaseDamage;
        player.GetCritChance<MeleeDamageClass>() += IncreaseCritRate;
        player.GetDamage<SummonDamageClass>() += IncreaseDamage;
        player.GetCritChance<SummonDamageClass>() += IncreaseCritRate;
        player.statDefense += Defense;
    }

    public override void AddRecipes()
    {
        CreateRecipe().
            AddIngredient<CorruptPendant>().
            AddIngredient<CrimsonPendant>().
            AddTile(TileID.WorkBenches).
            Register();
    }
}