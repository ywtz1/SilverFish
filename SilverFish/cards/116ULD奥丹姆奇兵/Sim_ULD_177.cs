using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots

{
    /// <summary>
    /// Octosari 
    /// ∞À◊¶æﬁπ÷
    /// </summary>
    class Sim_ULD_177 : SimTemplate
    {
        /// <summary>
        /// Deathrattle: Draw 8 cards.
        /// Õˆ”Ô£∫≥È∞À’≈≈∆°£
        /// </summary>
        /// <param name="p"></param>
        /// <param name="m"></param>
        public override void onDeathrattle(Playfield p, Minion m)
        {
            for (int i = 0; i < 8; i++)
            {
                p.drawACard(CardDB.cardName.unknown, m.own);
            }
        }
    }
}