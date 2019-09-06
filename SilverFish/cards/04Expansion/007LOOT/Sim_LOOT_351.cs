using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_351 : SimTemplate //* Greedy Sprite
    {
        //Deathrattle: Gain an empty Mana Crystal.

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.own) p.ownMaxMana = Math.Min(10, p.ownMaxMana + 1);
            else p.enemyMaxMana = Math.Min(10, p.enemyMaxMana + 1);
        }
    }
}