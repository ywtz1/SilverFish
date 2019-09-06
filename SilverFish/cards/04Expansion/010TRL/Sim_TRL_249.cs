using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_249 : SimTemplate//残酷集结
    {


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            if(target.own)
            {
                p.minionGetDestroyed(target);
                p.allMinionOfASideGetBuffed(ownplay, 1, 1);
                if(target.numAttacksThisTurn == 1||(target.windfury&&target.numAttacksThisTurn == 2))p.evaluatePenality-=10;

            }
            
        }

    }
}
