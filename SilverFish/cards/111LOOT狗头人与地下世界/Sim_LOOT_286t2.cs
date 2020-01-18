using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_286t2 : SimTemplate
	{

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_286t2);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
			p.equipWeapon(w, ownplay);
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
			foreach (Minion m in temp)
			{
			   if (!m.taunt)
			    {
					m.taunt = true;
					if (m.own) p.anzOwnTaunt++;
					else p.anzEnemyTaunt++;
				}							
			}
        }
	}
}