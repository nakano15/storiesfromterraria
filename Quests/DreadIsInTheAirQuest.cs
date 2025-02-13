using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class DreadIsInTheAirQuest : ModularQuestBase
{
    public override string Name => "Dread is in the Air";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => "For now, it seems like I've done enough for the Corruption. Maybe I should explore the world more and see what else can I find.";

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
        AddTalkObjective(DryadID, "You must be aware that there is a place in this world that shouldn't exist, and I'm talking about the Corruption.\nThe Corruption is like the disease of this world, the gangrena that infests this place, and it must be cured.\nI need you to brave that place and erradicate " + EaterOfSoulsKills + " Eater of Souls.\nDon't let them injure you, or else they will try to suck out your soul.");
        SetQuestStepStoryText("The Dryad want to speak with me.", "The Dryad told me of a place in this world known as The Corruption. That place is like the disease of this world, and that it must be cured. She told me to erradicate " + EaterOfSoulsKills + " Eater of Souls, and be careful not to be killed by them.");
        AddNewQuestStep();
        AddHuntObjective(NPCID.EaterofSouls, EaterOfSoulsKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "You killed them, huh? That's actually quite fruitless, since they will keep returning. At least you got the hang of dealing with them.\nI don't know if you saw some Mushrooms there, that are purple. I need you to bring me " + MushroomCount + " of them.");
        SetQuestStepStoryText("I killed enough number of Eater of Souls. I should tell the Dryad about this.", "Upon delivering the news that I defeated the Eater of Souls, the Dryad told me that doing that was pretty useless, but at least I got the hang ofdealing with them.\nShe then asked me to get some purple Mushrooms that are found there. "+MushroomCount+" of them to be exact.");
        SetStepExpReward(22, 15f);
        SetStepCoinReward(Silver: 4);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.VileMushroom, MushroomCount);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Just exactly what I needed. Hm... It seems like it can be purified with this powder. If you throw this powder on the Corrupted blocks, it should make them go back to normal, so you should be able to explore further the Corruption.\nHere, have some of them. I'll have more for sale if you need. Now, you need to take care of Devourers; worm like creatures that protects the Underground of the Corruption. " + DevourerKills + " of them should be enough.");
        SetQuestStepStoryText("I got enough Vile Mushrooms. Better I deliver them to the Dryad.", "I delivered the Vile Mushrooms I found in the Corruption to the Dryad. She managed to discover that a powder could purify it, so she gave the idea of using it on corrupted Blocks to cleanse them. That should help me explore further the corruption.\nShe said that if I need more Purification Powder, she will be selling more.\nShe then told me to defeat "+DevourerKills+" Devourers that appear on the Underground of the Corruption.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 15);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.DevourerHead, DevourerKills);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "Ah, you're back. I shouldn't have given you that task, since it's as useless as killing the Eater of Souls... Oh well, at least you tried your best.\nAnyways, it's time to destroy the heart of the Corruption. There are some Orbs protected within the veins of the Corruption. Shatter them with your hammer. Just don't try doing the same to the Altars found down there!");
        SetQuestStepStoryText("I defeated the Devourers. Better I let the Dryad know of that.", "I defeated the Devourers, and told the Dryad about my success, which she also said that shouldn't have given me the task, since was as useless as killing the Eater of souls.\nShe then told me to destroy the Corrupted Orbs found inside the Corruption, protected by its corrupted walls. A hammer should be handy to destroy them.\nShe told me not to try the same to the altars down there.");
        SetStepExpReward(23, 15f);
        SetStepCoinReward(Silver: 4, Copper: 40);
        AddStepItemReward(ItemID.PurificationPowder, 10);
        AddNewQuestStep();
        AddHuntObjective(NPCID.EaterofWorldsHead, 1);
        AddNewQuestStep();
        AddTalkObjective(DryadID, "I felt that. You killed something hungry and furious in the Underground Corruption, right? It seems like breaking those crystals infuriated that disease of a place. Good job.\nWhat you can do now is look for other areas with Corruption to break their orbs. That should help our world last longer.");
        SetQuestStepStoryText("While destroying the Orbs, I was attacked by a giant Devourer looking creature. I managed to defeat it, but better I tell the Dryad about this.", "After destroying a few Orbs, I was attacked by a Giant Corrupt Worm like creature. I managed to defeat it, then told later to the Dryad about this, who said that she felt when the creature appeared.\nShe said I did a god job, and that what I can do now, is look for other corruptions and destroy the crystals within them.\nThat should help our world last longer.");
        SetStepExpReward(24, 35f);
        SetStepCoinReward(Silver: 8, Copper: 40);
        AddStepItemReward(ModContent.ItemType<Items.Accessory.CorruptPendant>());
    }
}