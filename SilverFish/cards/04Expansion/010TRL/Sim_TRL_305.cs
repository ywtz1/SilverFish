using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_305: SimTemplate //* 新人登场
	{
		//Discover a minion that costs (8) or more. Summon it.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (p.ownHeroHasDirectLethal()) p.CallKid(CardDB.Instance.getCardData(CardDB.cardName.icehowl), pos, ownplay, false);
            else p.CallKid(CardDB.Instance.getCardData(CardDB.cardName.frostgiant), pos, ownplay, false);
        }
    }
}