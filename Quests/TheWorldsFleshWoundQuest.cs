using nterrautils;
using Terraria;
using Terraria.ID;

namespace storiesfromterraria.Quests;

public class TheWorldsFleshWoundQuest : ModularQuestBase
{
    public override string Name => "The World's Flesh Wound";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return WorldGen.crimson && (PlayerMod.GetPlayerQuestData(MainMod.GetPlayerCharacter(), QuestContainer.EvilAllAroundQuest, "storiesfromterraria") as ModularQuestData).Step >= 1;
    }

    const int DryadID = NPCID.Dryad;
    public int CrimeraKills = 24, FaceMonsterKills = 8;
    public int MushroomCount = 12;
    public int BloodCrawlerKills = 14;

    public TheWorldsFleshWoundQuest()
    {
        AddTalkObjective(DryadID, "This world has an anomaly in it, which was a result of a fight a Terrarian had with a godly creature long ago.\nThe blood of that creature has impregnated part of this world, turning even the grass into flesh, and spawning horrible antibodies in it.\nFor now, I need you to defeat some of those Antibodies: " + CrimeraKills + " Crimeras and " + FaceMonsterKills + " Face Monsters. They should start \"greeting\" you as you get closer to the Crimson.");
        AddNewQuestStep();
        AddHuntObjective(NPCID.Crimera, CrimeraKills);
        AddHuntObjective(NPCID.FaceMonster, FaceMonsterKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "You took care of them? Then you wont like to know that the Crimson itself is spawning more of them, so it didn't do much.\nFirst, I need something from the Crimson, so I can investigate the case, then I remembered those Red Mushrooms that were there.\nBring me " + MushroomCount + " of them, so I have enough to research. You should find them in fleshy grassy... Groundy..?");
        SetStepExpReward(22, 15f);
        SetStepCoinReward(Silver: 4);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.ViciousMushroom, MushroomCount);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Yes, those are the Mushrooms. They look tainted in the blood of that creature... Let me try... I see... This Powder purified the Mushroom. If it can purify this mushroom, then I believe it can be used to purify the Crimson blocks.\nHere, have some of them, I can sell you more should you need. Now, I need you to tackle the Blood Crawlers that roam the veins of the Crimson. " + BloodCrawlerKills + " of them should be enough.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 15);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective([NPCID.BloodCrawler, NPCID.BloodCrawlerWall], 14);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Good job at taking care of the Blood Crawlers, but I just remembered, that the Crimson will keep spawning more of them, so that was fruitless.\nAt least you seem confident that you can explore that place Underground. You should be able to strike at the Heart of the crimson, or better saying... The Hearts of the Crimson.\nInside the Crimson, there's some hearts being protected by Crimsonite walls, purify or explode those walls, and destroy those Hearts. Destroy as many as possible.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 40);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.BrainofCthulhu, 1);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Y-You're alive?! W-When I sensed the Brain of the creature in this world, I thought you'd be done for, but... You're here! It's amazing! Y-You might save our world!\nOkay, I should calm down now... Well, good job you did in the Crimson. What you can do now, is look for other Crimsons in this world, and destroy their Hearts. That should improve the safety of our world.");
        SetStepExpReward(24, 35f);
        SetStepCoinReward(Silver: 8, Copper: 40);
        //Need unique item reward.
    }
}