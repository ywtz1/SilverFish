using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_GIL_903: SimTemplate //* Frozen Clone
    {
        // Secret: After your opponent plays three cards in a turn, draw 2 cards.

        public override void onSecretPlay(Playfield p, bool ownplay, int number)
        {
            p.drawACard(CardDB.cardName.unknown, ownplay, true);
            p.drawACard(CardDB.cardName.unknown, ownplay, true);
        }
    }
}