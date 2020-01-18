using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_329 : SimTemplate //* Ixlid, Fungal Lord
    {
        //After you play a minion, summon a copy of it.

        public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
            int pos = (m.own) ? p.ownMinions.Count : p.enemyMinions.Count;
            if (pos < 7)
            {
                p.callKid(summonedMinion.handcard.card, pos, m.own);
                p.ownMinions[pos].setMinionToMinion(summonedMinion);
            }
        }
    }
}