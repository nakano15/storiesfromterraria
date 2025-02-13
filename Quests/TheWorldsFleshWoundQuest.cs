using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class TheWorldsFleshWoundQuest : ModularQuestBase
{
    public override string Name => "The World's Flesh Wound";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => "Maybe what I have done in the Crimson could help our world, but makes me wonder what else there is to find in this world.\nWe should definitely explore it more.";

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
        SetQuestStepStoryText("The Dryad seems to want to talk to me about something.", "The Dryad told me about a Terrarian that fought a godly creature long ago, and that caused a bloody anomaly that impregnated part of this world, turning even grass into flesh, and spawning antibodies in the place. That place is known as the Crimson.\nShe told me to defeat some of those Antibodies, and to begin with, she asked me to kill "+CrimeraKills+" Crimeras and "+FaceMonsterKills+" Face Monsters.");
        AddNewQuestStep();
        AddHuntObjective(NPCID.Crimera, CrimeraKills);
        AddHuntObjective(NPCID.FaceMonster, FaceMonsterKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "You took care of them? Then you wont like to know that the Crimson itself is spawning more of them, so it didn't do much.\nFirst, I need something from the Crimson, so I can investigate the case, then I remembered those Red Mushrooms that were there.\nBring me " + MushroomCount + " of them, so I have enough to research. You should find them in fleshy grassy... Groundy..?");
        SetQuestStepStoryText("I defeated the Crimeras and Face Monsters. The Dryad should know about my success.", "After defeating the Crimeras and Face Monsters, I told the Dryad about my success, which she said that I didn't do much, since the Crimson keeps spawning more of them.\nTo investigate the case, she told me of some Red Mushrooms that were found there, and told me to bring "+MushroomCount+" of them to her.");
        SetStepExpReward(22, 15f);
        SetStepCoinReward(Silver: 4);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.ViciousMushroom, MushroomCount);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Yes, those are the Mushrooms. They look tainted in the blood of that creature... Let me try... I see... This Powder purified the Mushroom. If it can purify this mushroom, then I believe it can be used to purify the Crimson blocks.\nHere, have some of them, I can sell you more should you need. Now, I need you to tackle the Blood Crawlers that roam the veins of the Crimson. " + BloodCrawlerKills + " of them should be enough.");
        SetQuestStepStoryText("I got the Vicious Mushrooms the Dryad asked for. Better I hand them to her.", "I gave the Vicious Mushrooms I found to the Dryad, and she managed to discover that a Powder could purify it. She said that since the powder can purify the mushroom, it should also purify the Crimson blocks.\nShe said that would be able to sell me more of the Purification Powder should I need.\nThen she asked me to go inside the Veins of the Crimson, and kill "+BloodCrawlerKills+" Blood Crawlers that roam inside.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 15);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective([NPCID.BloodCrawler, NPCID.BloodCrawlerWall], 14);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Good job at taking care of the Blood Crawlers, but I just remembered, that the Crimson will keep spawning more of them, so that was fruitless.\nAt least you seem confident that you can explore that place Underground. You should be able to strike at the Heart of the crimson, or better saying... The Hearts of the Crimson.\nInside the Crimson, there's some hearts being protected by Crimsonite walls, purify or explode those walls, and destroy those Hearts with a hammer. Destroy as many as possible.");
        SetQuestStepStoryText("I defeated the Blood Crawlers. I should tell the Dryad about that.", "After defeating the Blood Crawlers, I told the Dryad, and she said that just remembered that the Crimson would keep spawning more of them, so that was pretty fruitless.\nBut she said that I seem confident that I can explore the Underground Crimson.\nShe then told me that I should strike at the Hearts of the Crimson. They're protected by Crimsonite walls, whose I can either purify or explore, and then destroy the hearts with a hammer.\nShe told me to destroy as many as possible");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 40);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.BrainofCthulhu, 1);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Y-You're alive?! W-When I sensed the Brain of the creature in this world, I thought you'd be done for, but... You're here! It's amazing! Y-You might save our world!\nOkay, I should calm down now... Well, good job you did in the Crimson. What you can do now, is look for other Crimsons in this world, and destroy their Hearts. That should improve the safety of our world.");
        SetQuestStepStoryText("While I was destroying the Hearts of the Crimson, I was attacked by a Giant Brain. I managed to defeat it, but I should let the Dryad know about this.", "When destroying the Hearts of the Crimson, I was attacked by a Giant Brain.\nI defeated it, and then later let the Dryad know about that.\nShe looked surprised that I was alive, and told me that I should be able to save our world.\nThen she told me that I should look for other areas with Crimson in this world, and destroy their hearts, to improve our world safety.");
        SetStepExpReward(24, 35f);
        SetStepCoinReward(Silver: 8, Copper: 40);
        AddStepItemReward(ModContent.ItemType<Items.Accessory.CrimsonPendant>());
        //Need unique item reward.
    }
}