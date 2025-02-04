using nterrautils;
using nterrautils.QuestObjectives;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class GettingCraftyQuest : ModularQuestBase
{
    public override string Name => "Getting Crafty";

    public override string StoryStartLore => base.StoryStartLore;

    public override string StoryEndLore => "This should be the basic I need to know about crafting, and I should make use of that to make better equipment for my journey.";

    public override bool IsQuestActive(QuestData data)
    {
        return QuestContainer.HasQuestBeenCompleted(QuestContainer.NewBeginningQuest, "storiesfromterraria");
    }

    const int GuideID = NPCID.Guide;

    public int OreCollection = 80;

    public GettingCraftyQuest()
    {
        AddTalkObjective(GuideID, "If you're planning on going on an adventure, then you can't go simply like that: With only your body clothing. Unless you're like those people that does crazy things for views. You need proper equipment.\nTo have proper equipment, you need to have the furnitures specialized for helping you with crafting them.\nTo begin with, go Underground, and gather some Ores you find in your exploration. As many as you can find is handy.");
        SetQuestStepStoryText("I should find the Guide. He might have some useful tips for me.", "The Guide told me that I can't go venturing without proper equipment. He said that I need to craft furnitures specialized for crafting such gears, and that to begin with, I should get some Ores underground.");
        AddNewQuestStep();
        AddItemCollectionObjective([ ItemID.CopperOre, ItemID.TinOre, ItemID.IronOre, ItemID.LeadOre, ItemID.SilverOre, ItemID.TungstenOre, ItemID.GoldOre, ItemID.PlatinumOre ], "Ores", OreCollection, false);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "That's quite a variety of ores. To smelt them, It's best to make a Furnace. You can make one with 20 Stone Blocks, 4 Woods and a Torch. You need to craft it close to a Workbench.");
        SetQuestStepStoryText("I got a good amount of ores. I should speak with the Guide now.", "I have shown the ores to the Guide, and then he told me that I should craft a Furnace to smelt it into bars.\nHe said that I can make one with 20 Stone Blocks, 4 Woods and a Torch, while near a Workbench.");
        SetStepExpReward(6, 40f);
        SetStepCoinReward(Copper: 85);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Furnace, 1, false);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "Good, you made it. Place it somewhere that could be your workshop for crafting equipment. You can use the Furnace to smelt ores you find into Bars.\nOnce you get 8 of either Iron or Lead, you should be able to craft a Anvil, so that's what you should aim for next.");
        SetQuestStepStoryText("I crafted the Furnace as the Guide asked for. Better I show it to him.", "The Guide then told me that I should have some place in my world that should be my workshop, and place the Furnace there.\nHe told me that I can smelt ores into Bars on it, and that once I get 8 of either Iron or Lead Bars, I should be able to craft a Anvil, which is what I should be doing next.");
        SetStepExpReward(6, 40);
        SetStepCoinReward(Silver: 1, Copper: 20);
        AddNewQuestStep();
        AddItemCollectionObjective([ItemID.IronAnvil, ItemID.LeadAnvil], "Iron or Lead Anvil", 1, false);
        AddNewQuestStep();
        AddTalkObjective(GuideID, "You caught that quickly. Placing it on your workshop and standing close to it will allow you to craft better equipments. Now try to get yourself some gear for your defense, then return to me once you do that. If you don't have enough bars to craft more equipments, you can go underground and get more.");
        SetQuestStepStoryText("I crafted a Anvil as asked. Better I tell the Guide about it.", "I have made the Anvil, and should place it in my Workshop. While close to it, I can be able to craft equipments with the items I have in my inventory.\nThe Guide then asked me to get some gear for my defense, and return to him once I do.\nIf I don't have enough bars to craft the equipment, I can always go underground to get more.");
        SetStepExpReward(7, 40);
        SetStepCoinReward(Silver: 1, Copper: 30);
        AddNewQuestStep();
        GetLatestStep().AddNewObjective(new DefenseIncreaseObjective(6));
        AddNewQuestStep();
        AddTalkObjective(GuideID, "Look at you. That armor of you should help you endure some attacks coming to you, but it's still best to avoid being hurt at all costs.\nNot only you should be getting armors, but also weapons would be handy too. Now that you know how to craft equipments, you should be able to make some with the Bars you got.\nThat's all I got for you regarding crafting. You might end up having the need to add more crafting objects to allow you to make more things. If you want to find out how to make them, allow me to show what your materials can be used for.");
        SetQuestStepStoryText("I managed to craft and wear enough equipment now. Better I let the Guide see this.", "I have shown the armor set I made to the Guide, and he said that it should help me endure some attacks coming to me, but said that is best to avoid being hurt at all costs.\nHe also let me know that better weapons would be handy too, and that in the future I might need to cract better working furnitures to build more things.\nAnd also reminded me that I could see him in case I want to know what I can craft with the materials in my inventory.");
        SetStepExpReward(8, 60);
        SetStepCoinReward(Silver: 2, Copper: 50);
        AddStepItemReward(ItemID.WoodenArrow, 50);
    }
}