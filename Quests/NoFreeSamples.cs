using Ionic.Zip;
using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class NoFreeSamples : ModularQuestBase
{
    public override string Name => "No Free Samples";
    
    public override string StoryEndLore => "Beside I'd love having him give me some potions or anything else that would help me in my adventure, at least he gave me quite a sum of golds to buy them off him directly.\nWait... Is that his intention? Did he just gave me the coins just so I spend them on his store?\nWas I deceived in the end..? No... It cannot be..";

    public override bool IsQuestActive(QuestData data)
    {
        return NPC.AnyNPCs(NPCID.Merchant) || (data as ModularQuestData).Step > 0;
    }

    const int MerchantID = NPCID.Merchant;

    public int OrangeBloodrootCount = 3,
        WormPeelingCount = 4,
        LensCount = 8,
        BunniesCount = 12,
        BunnyStewCount = 11;

    public NoFreeSamples()
    {
        AddTalkObjective(MerchantID, "Hello kid. Nice house you got there. I hope you don't mind if I take it. You know, I need a place to store my goods.\nI'm the Merchant, who you'll be doing business with for quite long. I've got handy goods for you, and I might give you some coins if you help me with my things.");
        SetQuestStepStoryText("Someone new arrived at my village. I should see them.", "A Merchant has moved into my town. He said that I will be doing business with him for quite long, and that he might give me some coins in exchange for doing some tasks for him.");
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Speaking of help, I need your help with something. One of my clients is looking for " + OrangeBloodrootCount + " Orange Bloodroots, and the last adventurer I sent to the caves haven't returned yet.\nIf you find them, I'll pay you more than what those roots are worth.\nWhat do you say?");
        SetQuestStepStoryText("", "The first task he gave me was to get " + OrangeBloodrootCount + " Orange Bloodroots. He said that would pay more than what they're worth for, and that I should find them Underground.");
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.OrangeBloodroot, OrangeBloodrootCount);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Great job. Here you go, your reward. Are you up for more?\nAnother client of mine asked me to get " + WormPeelingCount + " Worm Peelings.\nIf you get them, I'll toss you more good items.");
        SetQuestStepStoryText("I've got all the Orange Bloodroots the Merchant asked me to get. I should deliver them right away.", "I delivered the Orange Bloodroots he asked for. Then he told me that there's another client of his asking for " + WormPeelingCount + " Worm Peelings.\nI think they're also found on the Underground.");
        SetStepExpReward(11, 40);
        SetStepCoinReward(Silver: 25 * OrangeBloodrootCount);
        AddNewQuestStep();
        AddObjectCollectionObjective("Worm Peeling", NPCID.GiantWormHead, 80f, WormPeelingCount);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Amazing! And you didn't managed to ruin them that much in the process too. I guess you've been hitting them in the head, where they're weaker.\nHere's your coins. Now there's another client that want " + LensCount + " Lens.\nAre you up to hunting some Demon Eyes for them? Of course you'll be paid for that.");
        SetQuestStepStoryText("I got all the Worm Peelings asked for. I should deliver them to the Merchant.", "The Merchant was impressed that I didn't managed to ruin the Worm Peelings in the process, then told me that must have been because I were hitting them on the head, where they're weaker.\nThen he told me that another client of him wants " + LensCount + " Lens.\nThey can be found sometimes by killing Demon Eyes, that appear during the night in the surface.");
        SetStepExpReward(12, 40);
        SetStepCoinReward(Silver: 12, Copper: 30);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Lens, LensCount);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Nicely done. Here's the coins.\nNow, are you up to do some critter catching? Get me " + BunniesCount + " Bunnies with the Bug Net I will lend you.\nTry not to ruin it by swinging it at monsters or something, because I'll take it back once the job is done.");
        SetQuestStepStoryText("I've got all the Lens the Merchant asked for.", "I delivered the Lens the Merchant asked me for. Now he saked me to collect "+BunniesCount+" Bunnies with a Bug Net he lended me.\nHe told me not to ruin it since he'll take it back once the job is done. Bunnies tend to survive near places populated with people.");
        SetStepExpReward(13, 40);
        SetStepCoinReward(Silver: 13, Copper: 50);
        AddStepItemReward(ItemID.BugNet);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Bunny, BunniesCount, false);
        AddItemCollectionObjective(ItemID.BugNet, 1);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Those Bunnies should make a good stew, but I have no idea how to cook that. I'm more specialized in trading, not cooking.\nYou've got a Cooking Pot here? You should be able to cook those Bunnies into a Bunny Stew in one. You should be able to craft them with Iron or Lead and Wood.\nAsk the Guide for more information about that. He seems invested in that kind of thing.");
        SetQuestStepStoryText("I've got the Bunnies the Merchant asked for. Better I deliver them right away, before they manage to jump out of my interdimensional pocket.", "I delivered the Bunnies to the Merchant, and he said they should make a good stew.\nHe then told me that if I got a Cooking Pot, I could cook them into Bunny Stew. He said I should be able to craft one with Iron or Lead and Wood, and that I should ask the Guide for more information about that.");
        SetStepExpReward(13, 40);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.BunnyStew, BunnyStewCount);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "I have to say, those Bunny Stews look delicious. You can keep one of them, should fix your hungry face. It must be really tough to go adventuring with the belly rumbling.\nOf course, one will be for me aswell, I need to eat too. The rest will go to my client. Here is the pay.\nNow comes my final request: some masochistic client asked me to find a Perfect Skull from Skeletons. The last Terrarians I asked that nearly quit the task right away. I hope you're not like them.");
        SetQuestStepStoryText("I made the Bunny Stews the Merchant asked for. Better I deliver them before they get cold.", "I delivered the Bunny Stews to the Merchant, and he let me keep one, saying that it must be tough to go adventuring with the belly rumbling.\nHe also kept one of them for himself, since he needs to eat, and then gave me my payment.\nThen he gave me his last request: Find a Perfect Skull. He said the last Terrarians he asked for that nearly quit the task right away, and he hopes that I'm not like them.\nOf course, the Skull comes from the Skeletons.");
        SetStepExpReward(14, 40);
        SetStepCoinReward(Silver: 15);
        AddNewQuestStep();
        AddObjectCollectionObjective("Perfect Skull", HandyValues.SkeletonNPCIDs, "Skeleton", 3.5f, 1);
        AddNewQuestStep();
        AddTalkObjective(MerchantID, "Wow! That skull got no cracks in it! And looks really well preserved. Nice job.\nI wouldn't have the patience to do that task, but good thing that I'm a Merchant, since I can pay others to do that instead.\nHere is your reward, should help you save some money wherever you are.");
        SetQuestStepStoryText("I found the Perfect Skull. Better I cautiously deliver it to the Merchant, to avoid breaking this thing.", "I delivered the Perfect Skull to the Merchant, and he got really impressed by how well preserved it is.\nHe gave me something that should help me save money wherever I am.");
        SetStepExpReward(15, 80);
        SetStepCoinReward(Silver: 20);
        AddStepItemReward(ItemID.MoneyTrough, 1);
    }
}