using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_419 : SimTemplate //* 
	{
		//树木学家
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp = (own.own) ? p.ownMinions : p.enemyMinions;
			foreach (Minion enemy in temp)
			{
				if (enemy.handcard.card.name==CardDB.cardName.treant) //enemy.handcard.card.name==CardDB.cardName.树人 || 
				{
					p.drawACard(CardDB.cardName.unknown, own.own, true);
					break;
				}
			}		
		}
	}
}