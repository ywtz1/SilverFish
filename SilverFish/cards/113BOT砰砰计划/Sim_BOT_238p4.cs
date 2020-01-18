using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_238p4: SimTemplate //* Siphon Life
    {
        // Hero Power: Lifesteal. Deal 3 damage.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardName.unknown, ownplay, true);
        }
    }
}