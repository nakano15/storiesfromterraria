using nterrautils;
using storiesfromterraria.Quests;

namespace storiesfromterraria;

public class QuestContainer : nterrautils.QuestContainer
{
    public const uint NewBeginningQuest = 0;
    protected override void CreateQuestDB()
    {
        AddQuest(NewBeginningQuest, new NewBeginningQuest());
    }
}