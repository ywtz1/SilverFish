using System;
using System.Collections.Generic;
using System.Text;


namespace HREngine.Bots
{
    class Sim_LOOT_367 : SimTemplate //* DrywhiskerArmorer
    {
        //Battlecry: For each enemy minion, gain 2 Armor.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int gain = (own.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            if (gain > 1) p.minionGetArmor(p.ownHero, 2 * gain);
        }
    }
}