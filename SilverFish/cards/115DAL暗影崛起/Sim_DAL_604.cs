using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_604 : SimTemplate //* Rhonin
	{
		//Deathrattle: Add 3 copies of Arcane Missiles to your hand.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardName.unknown, m.own, true);

        }
	}
}