using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_124 : SimTemplate //* Shadow Word: Horror
    {
        //Battlecry: Destroy all other_minions with 2_or_less_Attack.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            foreach (Minion m in p.enemyMinions)
            {
                if (m.Attack < 3) p.minionGetDestroyed(m);
            }
            foreach (Minion m in p.ownMinions)
            {
                if (m.Attack < 3) p.minionGetDestroyed(m);
            }
        }
    }
}