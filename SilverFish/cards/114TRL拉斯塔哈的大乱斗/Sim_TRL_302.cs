using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_TRL_302 : SimTemplate //

    {
        //<b>Battlecry:</b> Return a friendly minion to your hand and give it +2/+2."


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.ownHero.immune =true ;

        }

        public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
        {
            if (turnStartOfOwner == triggerEffectMinion.own)
            {
                p.ownHero.immune =false ;
            }
        }
    }
}