using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_165 : SimTemplate //* Backroom Bouncer
	{
		// Whenever a friendly minion dies, gain +1 Attack.

        public override void onMinionDiedTrigger(Playfield p, Minion m, Minion diedMinion)
        {
            if (m.own == diedMinion.own)
            {
                p.drawACard(CardDB.cardName.unknown, m.own, true);
            }
        }
    }
}