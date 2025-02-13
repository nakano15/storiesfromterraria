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
        SetQuestStepStoryText("There is someone new in this world. Maybe I should greet them.", "I've met a Dryad, who seems skeptical about knowing that I defeated a really dangerous creature lately.\nShe said that she's desperate so... I might do. But... Do for what?");
        AddNewQuestStep();
        AddQuestRequirementObjective(QuestContainer.DreadIsInTheAirQuest, "storiesfromterraria");
        SetLatestObjectiveAsOr();
        AddQuestRequirementObjective(QuestContainer.TheWorldsFleshWoundQuest, "storiesfromterraria");
        SetLatestObjectiveAsOr();
        AddNewQuestStep();
        AddTalkObjective(DryadID, "For now, that's all I got to ask from you. I hope this reward might be handy for your adventures, since it's a Dryad trinket. Farewell, Terrarian.");
        SetQuestStepStoryText("I managed to help the Dryad with a mission regarding the evils of this world. Better I talk with her again.", "I spoke with the Dryad again after helping her with a task regarding one of the world evils, and she gave me a Dryad trinket as reward.");
        //Need unique item reward.
    }
}