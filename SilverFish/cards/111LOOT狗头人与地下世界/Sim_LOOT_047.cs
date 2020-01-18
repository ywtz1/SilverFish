using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_047 : SimTemplate //* Barkskin
    {
        //Give a minion +3 Health. Gain 3 Armor.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetBuffed(target, 0, 3);
            p.minionGetArmor(ownplay ? p.ownHero : p.enemyHero, 3);
        }
    }
}