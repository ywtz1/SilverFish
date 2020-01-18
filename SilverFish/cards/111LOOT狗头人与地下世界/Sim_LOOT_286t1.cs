using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t1 : SimTemplate
	{

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t1);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
		   int pos = (ownplay)?
           p.ownMinions.Count : p.enemyMinions.Count;
			
			
		   p.callKid(kid, pos, ownplay, false);
			
		   p.callKid(kid, pos, ownplay);
        }
	}
}