using nterrautils;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class AHealthierResolutionQuest : ModularQuestBase
{
    public override string Name => "A Healthier Resolution";

    public override string StoryEndLore => "Beside the weird requests, having a Nurse in our world could be extremely handy, even more since we don't know the dangers that could tackle us.";

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
        AddTalkObjective(GuideID, "Hey Terrarian. I have an idea of something you can do to get you tougher.\nYes, you could always craft and equip new equipments, but you can also use a Life Crystal. Those rare crystals can be found underground, and will make you healthier when used. Go ahead and find one and use it.");
        SetQuestStepStoryText("I feel like the Guide want to talk with me.", "The Guide told me that he has an idea of something I can do to get tougher. Beside crafting new equipment, I could also find Life Crystals found underground, to increase my maximum health.\nHe said that I should find one and use it. If that's really that good, maybe I should look for more than one while I'm down there.");
        AddNewQuestStep();
        AddMaxHealthObjective(120);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "I can see that you've found and used a Life Crystal. Spare me of the details of how you used it, what matters is that now you got healthier.\nThat should help you survive more when exploring. It seems like there's a limit to how many of those you can use, but I can't pinpoint what is it, so my guess is... Find and use them until you can't anymore.");
        SetQuestStepStoryText("I have found and used a Life Crystal. Better I let the Guide know about this.", "The Guide noticed that I've used a Life Crystal. Good thing I didn't had to explain how.\nAnyways, he said that I should be able to survive longer now, and that looking for more of them should be handy.\nHe doesn't know if there's any limit to Life Crystal usage so.. Better I look for as many as I can, and use until I can't anymore.");
        SetStepExpReward(6, 40f);
        SetStepCoinReward(Silver: 1, Copper: 20);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "Ah, good thing you showed up. I've met someone wandering in the woods, who seems to be looking for a place to stay.\nMaybe we can persuade her to stay here, if you get her a house.\nCould you build one house for that person?");
        SetQuestStepStoryText("", "I was told by the Guide that there is someone looking for a place to stay in the wilds.\nI should build her a house to bring her here.");
        AddNewQuestStep();
        AddNpcMoveInObjective(NurseID);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Finally, I found people once again. I've been roaming the wilds and sleeping in dirty places, trying to look for a village I could settle in.\nDo you mind if I take that spare house? I could use one.");
        SetStepExpReward(6, 40f);
        SetQuestStepStoryText("Someone has arrived at my village. I should see them.", "A person has just shown up in my village and moved into my one of my houses. She said she has been roaming the wilds and sleeping in dirty places, looking for a village to settle in.\nI guess she did manage to find one.");
        AddNewQuestStep();
        AddTalkObjective(NurseID, "That's a great house. Could be my nursery room here. In case you didn't noticed, I'm a Nurse, and I will patch your wounds if you ever get hurt, if you pay me a price for that.\nBy the way, if I'm not abusing too much of you, would you mind collecting "+BatWingBandageCount+" Bat Wings? They could be handy for making bandages.\nYou should find those Bats underground.");
        SetQuestStepStoryText("", "That person told me that she's a Nurse, and that will heal me as long as I can pay for the treatment.\nShe then asked me if I would mind collecting " + BatWingBandageCount + " Bat Wings to make some bandages.\nShe said that the bats should be found in the Underground.");
        SetStepCoinReward(Silver: 2, Copper: 60);
        AddNewQuestStep();
        AddObjectCollectionObjective("Bat Wing Bandage", NPCID.CaveBat, 40f, BatWingBandageCount);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "You've got the improvised Bandages? Those should be handy for patching some wounds. Beside maybe their hide would be handier, but better I not dream too high.");
        SetQuestStepStoryText("I've got the Bat Wing Bandages the Nurse asked for. I should deliver them to her.", "I delivered the improvised bandages as she asked. She said their hide could be handier though..");
        SetStepExpReward(7, 40f);
        SetStepCoinReward(Silver: 1, Copper: 80);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Ah, you've returned. I'm in need of some Bone. And you may already wonder where you'll get the Bones...\nThat's right! Go hunt some Skeletons in the caverns.");
        SetQuestStepStoryText("", "Then I was asked to gather some Bones. Bones should be found from Skeletons in the Underground, so that's where I should go.");
        AddNewQuestStep();
        AddObjectCollectionObjective("Bone", HandyValues.SkeletonNPCIDs, "Skeletons", 65f, BoneCount);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "You've got them all. Those will be handy to give some sustainance to broken limbs.\nWhat? You don't want to have someone's arm helping keeping your limbs together? Don't be so childish.\nAnyways, that's all I needed, have this bandage. Should be able to save you from a death or two, if you're lucky.");
        SetQuestStepStoryText("I have gathered all the Bones the Nurse asked for. Better I deliver them.", "The Nurse said those Bones will be handy to give sustainance to broken limbs.\nAfter that, she said that's all she needed from me for now. And that should save me from a death or two, if I'm lucky..");
        SetStepExpReward(8, 40f);
        SetStepCoinReward(Silver: 3, Copper: 40);
        AddStepItemReward(ModContent.ItemType<Items.Accessory.BandOfHealingSurge>());
    }
}