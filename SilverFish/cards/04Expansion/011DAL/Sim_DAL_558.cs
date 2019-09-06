using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_DAL_558 : SimTemplate //* 大法师瓦格斯
	{



        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {

  
            if (m.own && ownplay)
            {
                if(hc.card.type == CardDB.cardtype.SPELL)
                p.evaluatePenality -= hc.card.cost*2;
            }
        

        }
	}
}