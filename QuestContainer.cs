using nterrautils;
using storiesfromterraria.Quests;

namespace storiesfromterraria;

public class QuestContainer : nterrautils.QuestContainer
{
    public const uint NewBeginningQuest = 0,
        WhenTheNightComesQuest = 1,
        AHealthierResolutionQuest = 2,
        NoFreeSamplesQuest = 3,
        GettingCraftyQuest = 4,
        BoomQuest = 5,
        EvilAllAroundQuest = 6,
        DreadIsInTheAirQuest = 7,
        TheWorldsFleshWoundQuest = 8,
        PoisonedQuest = 9;
    
    protected override void CreateQuestDB()
    {
        AddQuest(NewBeginningQuest, new NewBeginningQuest());
        AddQuest(WhenTheNightComesQuest, new WhenTheNightComesQuest());
        AddQuest(AHealthierResolutionQuest, new AHealthierResolutionQuest());
        AddQuest(NoFreeSamplesQuest, new NoFreeSamples());
        AddQuest(GettingCraftyQuest, new GettingCraftyQuest());
        AddQuest(BoomQuest, new BoomQuest());
        AddQuest(EvilAllAroundQuest, new EvilAllAroundQuest());
        AddQuest(DreadIsInTheAirQuest, new DreadIsInTheAirQuest());
        AddQuest(TheWorldsFleshWoundQuest, new TheWorldsFleshWoundQuest());
        AddQuest(PoisonedQuest, new PoisonedQuest());
    }
}