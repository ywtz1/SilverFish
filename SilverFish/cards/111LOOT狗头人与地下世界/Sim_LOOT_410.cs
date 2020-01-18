using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_410 : SimTemplate //* Duskbreaker
    {
        // Battlecry: If you're holding a Dragon, deal 3 damage to all other minions.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
			if(m.own)
			{
				bool dragonInHand = false;
				foreach (Handmanager.Handcard hc in p.owncards)
				{
					if ((TAG_RACE)hc.card.race == TAG_RACE.DRAGON)
					{
						dragonInHand = true;
						break;
					}	
				}
				if(dragonInHand) p.allMinionsGetDamage(3);
			}	
        }
    }
}