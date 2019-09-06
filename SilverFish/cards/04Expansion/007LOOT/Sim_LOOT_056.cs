using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_056 : SimTemplate //* Astral Tiger
    {
        //Deathrattle: Shuffle a copy of this minion into_your_deck.
   
        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.ownDeckSize++;
            }
            else
            {
                p.enemyDeckSize++;
            }
        }
    }
}