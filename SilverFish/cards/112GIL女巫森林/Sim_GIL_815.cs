using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_815 : SimTemplate //* Manic Soulcaster
	{
		// Battlecry: Choose a friendly minion. Shuffle a copy into your deck.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionAddToDeck(target, m.own);

                
            }
        }
    }
}