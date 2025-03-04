using nterrautils;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace storiesfromterraria.Quests;

public class PoisonedQuest : ModularQuestBase
{
    public override string Name => "Poisoned";

    public override string StoryStartLore => base.StoryStartLore;
    public override string StoryEndLore => base.StoryEndLore;

    public override bool IsQuestActive(QuestData data)
    {
        return NPC.AnyNPCs(NPCID.Nurse) && NPC.AnyNPCs(NPCID.ArmsDealer);
    }

    const int NurseID = NPCID.Nurse, ArmsID = NPCID.ArmsDealer;
    public int StingersCount = 45, JungleSpores = 30, HoneyCount = 50;

    public PoisonedQuest()
    {
        AddTalkObjective(NurseID, "Hey, listen! Have you seen that guy that has arrived? The one in trenchcoat? He seems to have been going to the Jungle recently, and I haven't seen him recently. Go check him please?");
        AddNewQuestStep();
        AddTalkObjective(ArmsID, "I dOn't fEEL so GoOoOoOoOoD! GoT stINgeRs oN my BacKSiDe! PlEAsE cALl a DocTOR. H3lP!");
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Oh my! He seems to be poisoned! I have an idea of how to try taking care of this issue. Gather " + StingersCount + " Stingers from the hornets in the Underground Jungle. I could use that as an antidote.");
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.Stinger, StingersCount);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Yes. Those are the stingers I need. Now I need you to find " + JungleSpores + " Jungle Spores for the remedy. Why didn't I asked you to get them all at once? Who's the doctor here? Not me? Yes, that's right. You think I don't know what I'm doing? Don't answer that. Now go gather them before the Arms Dealer dies.");
        SetStepExpReward(40, 15f);
        SetStepCoinReward(Silver: 6, Copper: 40);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.JungleSpores, JungleSpores);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "You got them all? Good. Here, deliver this medicine to the Arms Dealer, then let me know if he feels better after drinking it");
        SetStepExpReward(42, 15f);
        SetStepCoinReward(Silver: 6, Copper: 85);
        AddNewQuestStep();
        AddTalkObjective(ArmsID, "*You gave the medicine to the Arms Dealer*\nI sTIll DonT fEeL so GOOD. Why iS iT buRN! BLAGHUAHGUHAHURHGUAH!");
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Looks like it didn't worked! Maybe something with a even stronger poison has stung him. If that's the case.... It must have been the Queen Bee.\nFind her hive, lure her in and then defeat her, then bring me the poison she drops.");
        AddNewQuestStep();
        AddObjectCollectionObjective("Queen Bee Poison", NPCID.QueenBee, 100, 1);
        AddNewQuestStep();
        AddTalkObjective(NurseID, "That's it! That's the poison! I need " + HoneyCount + " Bottled Honey now. Yes, you could have gotten them by now, but It's really hard to think straight in such situations. Please make haste, the Arms Dealer might die if you delay.");
        SetStepExpReward(43, 15f);
        SetStepCoinReward(Silver: 6, Copper: 85);
        AddNewQuestStep();
        AddItemCollectionObjective(ItemID.BottledHoney, HoneyCount);
        AddNewQuestStep();
        //Based on Google Translator: 蜂蜜の瓶を集めるのを手伝ってくれてありがとう。手遅れになる前に、この薬を武器商人に届けてください。
        AddTalkObjective(NurseID, "Hachimitsu no bin o atsumeru no o tetsudatte kurete arigatō. Teokure ni naru mae ni, kono kusuri o buki shōnin ni todokete kudasai.");
        SetStepExpReward(44, 15f);
        SetStepCoinReward(Silver: 6, Copper: 85);
        AddNewQuestStep();
        AddTalkObjective(ArmsID, "Gwah!!");
        GetLatestStep().OnQuestStepEnd = ArmsDealerDeath;
        AddNewQuestStep();
        AddTalkObjective(NurseID, "Looks like we took too long... Oh well, better we wait for a similar parent of him to surge then... Why you're looking at me like that?");
        SetStepExpReward(45, 30f);
        SetStepCoinReward(Silver: 6, Copper: 85);
    }

    void ArmsDealerDeath(Player player, ModularQuestStepData data)
    {
        Main.npc[NPC.FindFirstNPC(ArmsID)].StrikeInstantKill();
    }
}