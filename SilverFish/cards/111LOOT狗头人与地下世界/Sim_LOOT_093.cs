using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_093: SimTemplate //* Call to Arms
	{
		//Recruit 3 minions that cost (2) or less.
		
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.GVG_058);
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay, false);
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
		}
	}
}