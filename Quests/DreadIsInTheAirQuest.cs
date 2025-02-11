using nterrautils;
using Terraria;
using Terraria.ID;

namespace storiesfromterraria.Quests;

public class DreadIsInTheAirQuest : ModularQuestBase
{
    public override string Name => "Dread is in the Air";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return !WorldGen.crimson && (PlayerMod.GetPlayerQuestData(MainMod.GetPlayerCharacter(), QuestContainer.EvilAllAroundQuest, "storiesfromterraria") as ModularQuestData).Step >= 1;
    }

    const int DryadID = NPCID.Dryad;
    public int EaterOfSoulsKills = 20;
    public int MushroomCount = 12;
    public int DevourerKills = 10;

    public DreadIsInTheAirQuest()
    {
        AddTalkObjective(DryadID, "You must be aware that there is a place in this world that shouldn't exist, and I'm talking about the Crimson.\nThe Crimson is like the disease of this world, the gangrena that infests this place, and it must be cured.\nI need you to brave that place and erradicate " + EaterOfSoulsKills + " Eater of Souls.\nDon't let them injure you, or else they will try to suck out your soul.");
        AddNewQuestStep();
        AddHuntObjective(NPCID.EaterofSouls, EaterOfSoulsKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "You killed them, huh? That's actually quite fruitless, since they will keep returning. At least you got the hang of dealing with them.\nI don't know if you saw some Mushrooms there, that are purple. I need you to bring me " + MushroomCount + " of them.");
        SetStepExpReward(22, 15f);
        SetStepCoinReward(Silver: 4);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.VileMushroom, MushroomCount);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Just exactly what I needed. Hm... It seems like it can be purified with this powder. If you throw this powder on the Corrupted blocks, it should make them go back to normal, so you should be able to explore further the Corruption.\nHere, have some of them. I'll have more for sale if you need. Now, you need to take care of Devourers; worm like creatures that protects the Underground of the Corruption. " + DevourerKills + " of them should be enough.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 15);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.DevourerHead, DevourerKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Ah, you're back. I shouldn't have given you that task, since it's as useless as killing the Eater of Souls... Oh well, at least you tried your best.\nAnyways, it's time to destroy the heart of the Corruption. There are some Crystals protected within the veins of the Corruption. Shatter them with your hammer. Just don't try doing the same to the Altars found down there!");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 40);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.EaterofWorldsHead, 1);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "I felt that. You killed something hungry and furious in the Underground Crimson, right? It seems like breaking those crystals infuriated that disease of a place. Good job.\nWhat you can do now is look for other areas with Corruption to break their crystals. That should help our world last longer.");
        SetStepExpReward(24, 35f);
        SetStepCoinReward(Silver: 8, Copper: 40);
    }
}