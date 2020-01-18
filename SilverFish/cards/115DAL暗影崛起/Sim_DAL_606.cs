using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_606 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if(target!=null)
            if(target.own)
            {
                p.minionGetDestroyed(target);
                //p.drawACard(CardDB.cardName.unknown, own.own,true);
                p.drawACard(CardDB.cardName.unknown, own.own,true);
                p.drawACard(CardDB.cardName.unknown, own.own,true);
                //p.evaluatePenality-=10;
            }
		}
	}
}