using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_650 : SimTemplate //tundrarhino
	{

//    eure wildtiere haben ansturm/.
        //todo charge?
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                //p.anzOwnTundrarhino++;
                foreach (Minion m in p.ownMinions)
                {
                    p.minionGetRush(m);
                }
            }
            else
            {
                //p.anzEnemyTundrarhino++;
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionGetRush(m);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                //p.anzOwnTundrarhino--;
                foreach (Minion m in p.ownMinions)
                {
                    p.minionLostRush(m);
                }
            }
            else
            {
                //p.anzEnemyTundrarhino--;
                foreach (Minion m in p.enemyMinions)
                {
                    p.minionLostRush(m);
                }
            }
        }

	}
}