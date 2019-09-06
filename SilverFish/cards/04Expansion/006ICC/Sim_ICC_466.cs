using System.Collections.Generic;
using HREngine.Bots;

namespace SilverFish.cards._04Expansion._006ICC
{
    class Sim_ICC_466: SimTemplate //* Saronite Chain Gang
    {
        // Taunt. Battlecry: Summon a copy of this minion.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.CallKid(m.handcard.card, m.zonepos, m.own);
            p.CallKid(m.handcard.card, m.zonepos, m.own);
            List<Minion> temp = (m.own) ? p.ownMinions : p.enemyMinions;
            int count = 0;
            foreach (Minion mnn in temp)
            {
                if (mnn.name == CardDB.cardName.saronitechaingang && m.entitiyID != mnn.entitiyID && mnn.playedThisTurn)
                {
                    mnn.setMinionToMinion(m);
                    count++;
                    if (count >= 2) break;
                }
            }
        }
    }
}