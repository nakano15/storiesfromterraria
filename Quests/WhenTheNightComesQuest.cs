using nterrautils;
using Terraria.ID;

namespace storiesfromterraria.Quests;

public class WhenTheNightComesQuest : ModularQuestBase
{
    public override string Name => "When the Night Comes";

    public override bool IsQuestActive(QuestData data)
    {
        Terraria.Player p = MainMod.GetPlayerCharacter();
        return QuestContainer.HasQuestBeenCompleted(QuestContainer.NewBeginningQuest, "storiesfromterraria");
    }

    public override string StoryStartLore => "The night was going to be upon us anytime soon, so I should prepare myself for it.";

    public override string StoryEndLore => "Anyways, I managed to survive through the nights in Terraria, and now, I have the rest of the world to explore.";

    const int GuideNPC = NPCID.Guide;
    public int ZombiesKill = 7;
    public int DemonEyeKill = 5;

    public WhenTheNightComesQuest()
    {
        AddTalkObjective(GuideNPC, "The night is coming. Are you scared? I wouldn't be surprised if you are.\nThere will be some flesh eating Zombies, and very aggressive Demon Eyes that will pop up around. I don't know why, but they surely want us dead.\nTo improve the safety of this place, would you be able to defeat " + ZombiesKill + " Zombies? I will even give you some potions to help with your survival.");
        SetQuestStepStoryText("The Guide looks quite anxious. I should see him.", "The Guide was also waiting for the night to come.\nHe told me that Zombies and Demon Eyes would begin showing up during the night.\nHe asked me to kill " + ZombiesKill + " Zombies to improve the safety of the area, and even gave me some Healing Potions to help me with that.");
        AddStepItemReward(ItemID.LesserHealingPotion, 5);
        AddNewQuestStep();
        AddHuntObjective(HandyValues.ZombieNPCIDs, ZombiesKill);
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "You surely took care of those zombies, but I don't think that will stop them from returning. Still, that was great.\nNow, you should deal with the other nightly problem: The Demon Eyes. Would you be able to remove "+DemonEyeKill+" of them from the sky?\nThere's even more potions to help.");
        SetQuestStepStoryText("I took care of the number of Zombies the Guide asked me to.\nI should tell him about that.", "The Guide looked okay about knowing that I defeated those Zombies, but he feels like that was fruitless.\nHe then asked me to kill "+DemonEyeKill+" Demon Eyes, while also giving me more Healing Potions.");
        SetStepExpReward(7, 30f);
        SetStepCoinReward(Silver: 1, Copper: 25);
        AddStepItemReward(ItemID.LesserHealingPotion, 3);
        AddNewQuestStep();
        AddHuntObjective(HandyValues.DemonEyeNPCIDs, DemonEyeKill);
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "You beauty. The way those Demon Eyes were falling on the ground was really exciting to watch.\nBut looks like you angered something really big. I can see sometimes in the horizon a huge eye watching us.\nThat's the Eye of Cthulhu, and it should be showing up at any night, unless you decide to take on it right away.");
        SetQuestStepStoryText("I killed the Demon Eyes he asked to. I should let the Guide know about that.", "He called me a \"beauty\"? I'm not sure what that is about, but he seemed happy for knowing I killed those Demon Eyes.\nBut he fears that I might have attracted the attention of the Eye of Cthulhu, a huge eye creature that watches us through the night.\nI should prepare myself for the fight.");
        SetStepExpReward(8, 40f);
        SetStepCoinReward(Silver: 1, Copper: 60);
        AddStepItemReward(ItemID.LesserHealingPotion, 3);
        AddNewQuestStep();
        AddHuntObjective(NPCID.EyeofCthulhu, 1);
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "You managed to triumph over the Eye of Cthulhu? Wow! That's impressive. You've grown stronger in the short time we've met.\nMaybe you might even be able to save our world... Save from what you ask? You'll find out.\nFor now, better you get some rest, because tomorrow there's more for you to do.");
        SetQuestStepStoryText("I have defeated the Eye of Cthulhu. The Guide should know about this.", "I have defeated the Eye of Cthulhu, and let the Guide know about that.\nHe said that's impressive, and that I've grown stronger in the short time we've met.\nHe even mentioned I might be able to save our world, but he refused to tell me from what. Said that I would find out..?");
        SetStepExpReward(10, 50f);
        SetStepCoinReward(Silver: 2, Copper: 50);
        AddStepItemReward(ItemID.LesserHealingPotion, 5);
    }
}