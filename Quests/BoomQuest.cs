using Ionic.Zip;
using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class BoomQuest : ModularQuestBase
{
    public override string Name => "Boom!";

    public override string StoryStartLore => base.StoryStartLore;
    public override string StoryEndLore => "Beside was quite tough to do his request, at least this reward should be worth all the effort I went through to fulfill it.";

    public override bool IsQuestActive(QuestData data)
    {
        return NPC.AnyNPCs(NPCID.Demolitionist) || (data as ModularQuestData).Step > 0;
    }

    const int DemoNPC = NPCID.Demolitionist;

    public int CopperTinOreCount = 350,
        SkeletonKill = 18;

    public BoomQuest()
    {
        AddTalkObjective(DemoNPC, "Ah, a new place to settle. Should be good to hang around when I'm not out there mining.\nMe? I'm a demolitionist. I don't use pickaxes, I use bombs. Speaking of which, maybe you could use them to gather some Copper and Tin ores.\nAbout " + CopperTinOreCount + " of them should do.");
        SetQuestStepStoryText("Someone has arrived at one of my villages.", "I've met a new villager today. This time is a Demolitionist. He said that he doesn't use Pickaxes, he uses Bombs instead.\nHopefully he wont use them in one of the houses. He asked me to collect " + CopperTinOreCount + " Copper or Tin Ores underground, and gave me a few bombs that could be useful for that.");
        AddStepItemReward(ItemID.Bomb, 5);
        AddNewQuestStep();
        AddItemCollectionObjective([ItemID.CopperOre, ItemID.TinOre], "Copper or Tin Ore", CopperTinOreCount);
        AddNewQuestStep();
        AddTalkObjective(DemoNPC, "Very nice. That's quite a haul of ores. Not sure what they could be useful for by the way, maybe if we had a Mechanic could find more use.\nNow I need you to do a little revenge for me. Those Skeletons underground have been ruining my demolition jobs, and I didn't liked that. Blow " + SkeletonKill + " of them, will ya? They can be found in the Caverns.\nUse those grenades on them, if you want. Or hold them, if you want.");
        SetQuestStepStoryText("I've got the Copper or Tin Ores the Demolitionist asked for. I should deliver them to him.", "I delivered the Copper or Tin Ores I found to the Demolitionist. He said I got quite a haul of them, but can't find much use for them. Maybe a Mechanic would find more use on them.\nHe then asked me to have some revenge on Skeletons in the Caverns, whose have been ruining his Demolition jobs.\nHe told me to blow " + SkeletonKill + " Skeletons, and even gave me some Grenades to use against them, if I want.");
        SetStepExpReward(14, 15f);
        SetStepCoinReward(Silver: 2, Copper: 40);
        AddStepItemReward(ItemID.Bomb, 5);
        AddStepItemReward(ItemID.Grenade, 15);
        AddNewQuestStep();
        AddHuntObjective(HandyValues.SkeletonNPCIDs, SkeletonKill, "Skeleton");
        AddNewQuestStep();
        AddTalkObjective(DemoNPC, "Hehehe. By the sounds of the explosions, you were busy down there. Good job.\nYou got some money? I need a replacement of my Mining Helmet, and I'm kinda lazy to go look for a Merchant to buy it.\nIf you get it for me, I'll give you quite a haul of grenades.");
        SetQuestStepStoryText("The Skeletons are now history. So better I tell the Demolitionist about that.", "I defeated the Skeletons, and delivered the news to the Demolitionist, who said that heard the sound of the Skeletons explosions. He then asked me to buy a Mining Helmet from a Merchant, because he's lazy. He promissed me a haul of grenades if I do that.");
        SetStepExpReward(14, 15f);
        SetStepCoinReward(Silver: 2, Copper: 65);
        AddStepItemReward(ItemID.Bomb, 5);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.MiningHelmet, 1);
        AddNewQuestStep();
        AddTalkObjective(DemoNPC, "Nice and functional. And good as new aswell. Great.\nAs promissed, here quite a bunch of grenades. Now I have to ask you one final thing. I better mining clothing for particular reasons.\nThis one has holes even in places I'd rather not mention, so better I have some new clothing, so go find some Skeleton Miners, and get their clothings.\nThey should probably be better than what I got right now. Those Skeleton Miners can occasionally be found in the Caverns. You can spot them because they also have a very bright Mining Helmet.");
        SetQuestStepStoryText("I got the Mining Helmet. I should deliver it to the Demolitionist.", "I got the Mining Helmet, and delivered it to the Demolitionist, who said that it was Nice and Functional, aswell as Good as New. He gave me the bunch of grenades he promissed, and then gave me one last task.\nHe asked me to go in the Caverns again, and hunt for Skeleton Miners, and get their Clothings, because his are full of holes.\nThose Skeleton Miners are found in the Caverns, and they have a Mining Helmet too, so should be easier to spot them in the dark.");
        SetStepExpReward(15, 15f);
        SetStepCoinReward(Silver: 2, Copper: 65);
        AddStepItemReward(ItemID.Grenade, 100);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.MiningShirt, 1);
        AddItemCollectionObjective(ItemID.MiningPants, 1);
        AddNewQuestStep();
        AddTalkObjective(DemoNPC, "Nice! A new haul of clothing... And it's completely burned out and ripped. Looks even worser than what I got right now.\nWhat? No way I'm wearing that. I'm better using what I got now. You want your reward? Yeah, right, you had to go there and get those scraps anyway.\nThere, have this Grenades Bundle, it should be handy for you.");
        SetQuestStepStoryText("I found the new clothing for the Demolitionist, now I should deliver them to him.", "I found and delivered the clothing to the Demolitionist, with huge effort. He said that the Mining Clothing I found underground is in worser state than his current outfit, so he refused to wear it. But he still gave me a reward for my effort.");
        SetStepExpReward(15, 35f);
        SetStepCoinReward(Silver: 4, Copper: 50);
        AddStepItemReward(ItemID.Grenade, 15);
        AddStepItemReward(ModContent.ItemType<Items.Weapons.GrenadesBundle>());
    }
}