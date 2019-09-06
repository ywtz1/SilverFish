using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_529 : SimTemplate //* Void Ripper
	{
		//Battlecry: Swap the Attack and Health of all other minions.

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            foreach (Minion m in p.ownMinions)
            {
                p.minionSwapAngrAndHP(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
            	p.minionSwapAngrAndHP(m);
            }				
		}
	}
}