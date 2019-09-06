using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_727 : SimTemplate //* Grimestreet Outfitter
	{
		            CardDB.Card c = null;       CardDB.Card c2 = null;
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.type == CardDB.cardtype.MOB&&p.restcard(cn.Key)>0)
                    {
                        if(c2==null){c2=c;continue;}
                        if(c.cost < c2.cost){c2=c;}

                    }
                }
                    p.drawACard(c2.cardIDenum, ownplay);

        }
	}
}