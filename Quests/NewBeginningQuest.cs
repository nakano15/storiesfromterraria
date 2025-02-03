using nterrautils;
using Terraria.ID;

namespace storiesfromterraria.Quests;

public class NewBeginningQuest : ModularQuestBase
{
    public override string Name => "New Beginning";
    public override string StoryStartLore => "I just begun my journey, and entered my first world.";
    public override string StoryEndLore => "And so ended the basics of my journey, and now begins my story.";

    public int GuideNPC => NPCID.Guide;
    public int WoodGatherCount = 50;
    public int StoneBlocksCount = 50;
    public int GelCount = 5;

    public override bool IsQuestActive(QuestData data)
    {
        return true;
    }

    public NewBeginningQuest()
    {
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "Hello. Are you new here? I am the Guide, and I will help you quickstart your journey.\nFirst of all, you need to gather wood. Use that axe you have, and cut down trees until you have "+WoodGatherCount+" Wood Blocks.");
        SetQuestStepStoryText("Upon arriving, I met a man that has arrived with me.\nI should speak with him.", "Upon arriving, I met a man that has arrived with me. I spoke to him, and he said he's the Guide, and that he will quickstart my journey.\nThe Guide asked me to collect some Wood from trees by using my axe.");
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Wood, WoodGatherCount, false);
        SetQuestStepStoryText("I should be able to get those by hitting trees with a axe, until they're destroyed.", "");
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "Very nice! You can build a house with that wood to survive the night. Dangerous monsters appear during the night.\nYou can also use that wood to craft items that will be handy for you.\nYou have got some Acorns, right? You can use them on the ground to grow more trees. It's best to have trees around.");
        SetQuestStepStoryText("I should deliver those wood blocks to the Guide to see.", "I did so and have shown the Guide the wood I got, and he said that I could build a house with it, to survive the night, since dangerous monsters appear during the night.\nHe also told me that I could craft items with them too, and that I could plant Acorns to grow more trees.");
        SetStepExpReward(1, 40f);
        SetStepCoinReward(Copper: 50);
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "Since you got some wood, then you should try making a Workbench with it.\nThe Workbench will allow you to craft more things than you could do by hand.\nOpen your inventory and craft yourself a Workbench with the wood you got.");
        SetQuestStepStoryText("The Guide seems to want to talk to me.", "The Guide told me that I should be able to craft a Workbench with the Wood I got.\nHe told me that it would help me crafting more things that I can't make by hand.");
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.WorkBench, 1, false);
        SetQuestStepStoryText("I should be able to craft the Workbench through the inventory.", "");
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "Now that you got the Workbench, you can place it on the ground, and you see more recipes appear when you check recipe list while close.\nNow, lets make use of some mining.\nUse your Pickaxe to gather "+StoneBlocksCount+" Stone Blocks.\nYou can find a cave, or even dig somewhere downwards to find more stones.\nJust watch where you're mining.");
        SetQuestStepStoryText("I should show the Workbench to the Guide.", "Now that I got the Workbench. I can place it on the ground, and have more recipes show up when I stay close to it.\nHe then told me that I should make use of my pickaxe, and gather some Stone Blocks.");
        SetStepExpReward(2, 40f);
        SetStepCoinReward(Copper: 50);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.StoneBlock, StoneBlocksCount, false);
        SetQuestStepStoryText("I should be able to find the Stone Blocks in a cave. If I'm unlucky to find one, I should begin digging the dirt to look for some underground.", "");
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "You seem to have got the hang of it. You can also find ores underground, and smelt them in a Furnace to create bars, and use them to craft better equipments.\nBeside the Stone can have its crafting uses, you can also use some to improve your house.\nBut now, you need a lighting source, so kill some slimes and get "+GelCount+" Gels from them.\nThey eventually appear in the forest.");
        SetQuestStepStoryText("I got the Stone Blocks the Guide asked me to.\nI should go show him them.", "I brought the Stone Blocks to the Guide, who said I got the hang of mining.\nHe said I could find ores underground, and smelt them in a Furnace to create bars, and craft better equipments.\n\nHe also told me that I can use Stone for improving my house aswell.\n\nThen, he told me to get some Gels from Slimes.");
        SetStepExpReward(3, 40f);
        SetStepCoinReward(Copper: 50);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Gel, GelCount, false);
        SetQuestStepStoryText("I should be able to find Slimes at the surface during the day.", "");
        AddNewQuestStep();
        AddTalkObjective(GuideNPC, "Good job. You can craft torches by using Wood and Gel. That will give you some lighting, that you can even place on walls.\nNow, I have a favor to ask of you: I need a house. For a valid house, I need it to have background wall, some lighting, like a torch, a chair, a table, and some way of entering it, like a platform or door.\nPlease make one before night comes.");
        SetQuestStepStoryText("I should deliver the Gels to the Guide.", "After I collected the Gels, the Guide said I could make a Torch by using Wood and Gel.\nThat should help me in the night, and also dark places. I can even place it on walls.\n\nHe then asked me to build him a house.\nFor him to have a valid house, it should have:\na background wall; some lighting, like a torch; a chair; a table; and some way of entering it, like a platform or a door.");
        SetStepExpReward(4, 40f);
        SetStepCoinReward(Copper: 50);
        AddNewQuestStep();
        AddNpcMoveInObjective(GuideNPC);
        SetQuestStepStoryText("Once I build a house for the Guide, I can either assign him that house, or wait for him to move in.", "");
        AddNewQuestStep();
        SetStepExpReward(5, 55f);
        SetStepCoinReward(Copper: 50);
        AddTalkObjective(GuideNPC, "That's a nice looking house. That should keep us safe for the night. May not seem like it, but this is actually a dangerous place at night, so we best stay inside, unless you're confident you can survive.");
        SetQuestStepStoryText("The Guide has moved in. I should hear what he has to say.", "The Guide has moved in, and said that he liked the house.\nHe said that the house should keep us safe for the night, because this place is really dangerous at night, so he said it's best to stay at home.\nI could also try exploring during the night, if I'm confident I'll survive.");
    }
}