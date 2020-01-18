using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_054 : SimTemplate //* Branching Paths
    {
        //Choose Twice - Draw a card; Give your minions +1 Attack; Gain 6 Armor.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 2; i++)
            {
                if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
                {
                    p.allMinionOfASideGetBuffed(ownplay, 1, 0);
                }
                if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
                {
                    if (ownplay) p.minionGetArmor(p.ownHero, 6);
                    else p.minionGetArmor(p.enemyHero, 6);
                }
                if (choice == 3 || (p.ownFandralStaghelm > 0 && ownplay))
                {
                    p.drawACard(CardDB.cardName.unknown, ownplay);
                }
            }
        }
    }
}