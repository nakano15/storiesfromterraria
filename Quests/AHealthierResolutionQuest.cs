using nterrautils;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class AHealthierResolutionQuest : ModularQuestBase
{
    public override string Name => "A Healthier Resolution";

    public override string StoryStartLore => base.StoryStartLore;
    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return QuestContainer.HasQuestBeenCompleted(QuestContainer.NewBeginningQuest, "storiesfromterraria");
    }

    const int GuideID = NPCID.Guide,
        NurseID = NPCID.Nurse;

    public int BatWingBandageCount = 8,
        BoneCount = 4;

    public AHealthierResolutionQuest()
    {
        AddTalkObjective(GuideID, "Hey Terrarian. I have an idea of something you can do to get you tougher.\nYes, you could always craft and equip new equipments, but you can also use a Life Crystal. Those rare crystals can be found underground, and will make you healthier when used. Go ahead and find one.");
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.LifeCrystal, 1, false);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "Yes, that's the Life Crystal. Go ahead and use it. You'll get healthier from doing so.\nThat should help you survive more.");
        SetStepExpReward(6, 40f);
        SetStepCoinReward(Silver: 1, Copper: 20);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Finally, I found people once again. I've been roaming the wilds and sleeping in dirty places, trying to look for a village I could settle in.\nDo you have a spare house? I could use one.");
        AddNewQuestStep();
        AddNpcMoveInObjective(NurseID);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "That's a great house. Could be my nursery room here. In case you didn't noticed, I'm a Nurse, and I will patch your wounds if you ever get hurt, if you pay me a price for that.\nBy the way, if I'm not abusing too much of you, would you mind collecting "+BatWingBandageCount+" Bat Wings? They could be handy for making bandages.\nYou should find those Bats underground.");
        SetStepExpReward(6, 40f);
        SetStepCoinReward(Silver: 2, Copper: 60);
        AddNewQuestStep();
        AddObjectCollectionObjective("Bat Wing Bandage", NPCID.CaveBat, 40f, BatWingBandageCount);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "You've got the improvised Bandages? Those should be handy for patching some wounds. Beside maybe their hide would be handier, but better I not dream too high.\nAh, the Guide was looking for you. I have no idea what he wants, by the way...");
        SetStepExpReward(7, 40f);
        SetStepCoinReward(Silver: 1, Copper: 80);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "I see that you've got another person to move in here, and I didn't even needed to tell you anything, which is great.\nHaving more people moving here is better for everyone. You just need to watch out if they're happy with where they live, and with who they live.\nIf they're happy where they live, they might make things more favorable for you, and charge you less.");
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Ah, you've returned. I'm in need of some Bone. And you may already wonder where you'll get the Bones...\nThat's right! Go hunt some Skeletons in the caverns.");
        AddNewQuestStep();
        AddObjectCollectionObjective("Bone", HandyValues.SkeletonNPCIDs, "Skeletons", 65f, BoneCount);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "You've got them all. Those will be handy to give some sustainance to broken limbs.\nWhat? You don't want to have someone's arm helping keeping your limbs together? Don't be so childish.\nAnyways, that's all I needed, have this bandage. Should be able to save you from a death or two, if you're lucky.");
        SetStepExpReward(8, 40f);
        SetStepCoinReward(Silver: 3, Copper: 40);
        AddStepItemReward(ModContent.ItemType<Items.Accessory.BandOfHealingSurge>());
    }
}