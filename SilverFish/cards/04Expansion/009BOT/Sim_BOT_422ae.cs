using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_422ae : SimTemplate //* 施肥
	{
        //Give your other minions +1/+1.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            List<Minion> temp = (ownplay) ? p.ownMinions : p.enemyMinions;
            foreach (Minion m in temp)
            {
                if (target.entitiyID != m.entitiyID) p.minionGetBuffed(m, 1, 1);
            }
		}

	}
}