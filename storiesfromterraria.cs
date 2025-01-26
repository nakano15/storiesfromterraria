using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using nterrautils;

namespace storiesfromterraria
{
	public class storiesfromterraria : Mod
	{
        public override void Load()
        {
			nterrautils.QuestContainer.AddQuestContainer(this, new QuestContainer());
        }
    }
}
