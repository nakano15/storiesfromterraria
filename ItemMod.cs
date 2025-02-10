using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria;

public class ItemMod : GlobalItem
{
    public override void SetDefaults(Item entity)
    {
        switch (entity.type)
        {
            case ItemID.Grenade:
                entity.ammo = entity.type;
                break;
        }
    }
}