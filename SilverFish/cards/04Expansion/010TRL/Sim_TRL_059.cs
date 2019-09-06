using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_059 : SimTemplate //* wandering monster
    {
        //Secret: When an enemy attacks your hero, summon a 3-Cost minion as the new target.


        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null) p.minionReturnToHand(target, target.own, 0,2,2);

        }
    }
}