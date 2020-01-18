using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_BOT_103 : SimTemplate //观星者
    {


        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
            int c=p.owncards.Count;

            
            if (m.own && ownplay)
            {
                if(hc.position==c)p.drawACard(CardDB.cardName.unknown, m.own, false);
            }

        }

    }
}