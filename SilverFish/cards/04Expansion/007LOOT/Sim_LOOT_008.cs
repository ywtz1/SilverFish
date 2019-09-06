using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_008 : SimTemplate //* Psychicscream
    {
        //fxxk

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
         int a = p.ownMinions.Count + p.enemyMinions.Count;

            /*foreach (Minion m in p.enemyMinions)
            {
                p.minionReturnToDeck(m, !ownplay);
            }
            foreach (Minion m in p.ownMinions)
            {
                p.minionReturnToDeck(m, !ownplay);
            }*/

          foreach (Minion m in p.ownMinions)
            {
                p.minionGetDestroyed(m);
                p.minionAddToDeck(m,!ownplay);
                p.minionGetSilenced(m);
            }
            foreach (Minion m in p.enemyMinions)
            {
                p.minionGetDestroyed(m);
                p.minionAddToDeck(m,!ownplay);
                p.minionGetSilenced(m);
            }


        }
    }
}