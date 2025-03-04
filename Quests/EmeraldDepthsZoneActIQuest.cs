using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class EmeraldDepthsZoneActIQuest : ModularQuestBase
{
    public override string Name => "Emerald Depths Zone - Act:I";

    public override string StoryStartLore => base.StoryStartLore;
    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return QuestContainer.HasQuestBeenCompleted(QuestContainer.EvilAllAroundQuest, "storiesfromterraria") && NPC.AnyNPCs(NPCID.Dryad);
    }

    const int DryadID = NPCID.Dryad;

    public EmeraldDepthsZoneActIQuest()
    {
        AddTalkObjective(DryadID, "");
    }
}