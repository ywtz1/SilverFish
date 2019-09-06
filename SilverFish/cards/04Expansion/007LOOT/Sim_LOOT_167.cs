using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_167 : SimTemplate //* Fungalmancer 菌菇术士
	{
        //Battlecry:Give adjacent minions +2/+2


		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            List<Minion> temp =(own.own) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (m.zonepos == own.zonepos - 1 || m.zonepos == own.zonepos + 1)
                { p.minionGetBuffed(m, 2, 2); }
            }
		}

	}
}