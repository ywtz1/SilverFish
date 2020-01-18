using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_520 : SimTemplate //* The Skeleton Knight
	{
		//Deathrattle: Reveal a minion in each deck. If yours costs more, return this to your hand.


        public override void onDeathrattle(Playfield p, Minion m)
        {
			p.drawACard(CardDB.cardName.unknown, m.own);            

        }
	}
}