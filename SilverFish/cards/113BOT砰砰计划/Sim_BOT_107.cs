using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_107 : SimTemplate //* Grimestreet Outfitter
	{
		// Battlecry: Give all minions in your hand +2/+2.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            //p.cili(own);
        }
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
        	int dmg = 1;
            p.allCharsGetDamage(dmg);
        }


	}
}