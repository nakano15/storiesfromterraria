using nterrautils;
using Terraria;
using Terraria.ID;

namespace storiesfromterraria.Quests;

public class EvilAllAroundQuest : ModularQuestBase
{
    public override string Name => "Evil All Around";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return NPC.AnyNPCs(NPCID.Dryad) || (data as ModularQuestData).Step > 0;
    }

    const int DryadID = NPCID.Dryad;

    public EvilAllAroundQuest()
    {
        AddTalkObjective(DryadID, "Interesting, I never would have thought I'd see a village in here. Ah, where are my manners. I'm the Dryad, and I came here because I have some hope. Someone here has defeated a really dangerous creature recently, and I wanted to talk to them.\nWait, that is you? You're the one who defeated the creature? That's quite hard to believe. Well... I'm desperate anyways, so I guess you'll do then.");
        AddNewQuestStep();
        AddQuestRequirementObjective(QuestContainer.DreadIsInTheAirQuest, "storiesfromterraria");
        SetLatestObjectiveAsOr();
        AddQuestRequirementObjective(QuestContainer.TheWorldsFleshWoundQuest, "storiesfromterraria");
        SetLatestObjectiveAsOr();
        AddNewQuestStep();
        AddTalkObjective(DryadID, "For now, that's all I got to ask from you. I hope this reward might be handy for your adventures, since it's a Dryad trinket. Farewell, Terrarian.");
        //Need unique item reward.
    }
}