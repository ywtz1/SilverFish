using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_540 : SimTemplate //Dragonhatcher
	{
		//At the end of your turn, Recruit a Dragon.
		


        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
				p.zhaomu(triggerEffectMinion.own,TAG_RACE.DRAGON,0,0);

            }
        }
	}
}