using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_504 : SimTemplate //* Evolve
	{
		//Transform your minions into random minions that cost (1) more.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{       
			if(target!=null)
			{
				int mana=target.handcard.card.cost + 1;
            	p.minionTransform(target, p.getRandomCardForManaMinion(mana));
            	p.drawACard (CardDB.cardIDEnum.LOOT_504t,ownplay,true,true);
	            /*
	            
	            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
	            foreach (Minion m in temp )
	            {
	            	if(target==m)
	                {
	                	p.minionTransform(m, p.getRandomCardForManaMinion(m.handcard.card.cost + 1));
	                	break;
	                }
	            }
	            */
			}
		}
	}
}