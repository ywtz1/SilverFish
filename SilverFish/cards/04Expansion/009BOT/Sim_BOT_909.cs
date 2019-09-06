using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_909 : SimTemplate //* 水晶学
	{
		// Battlecry: Give all minions in your hand +2/+2.
            CardDB.Card c = null;       CardDB.Card c2 = null;  CardDB.Card c3 = null;    // 
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.type == CardDB.cardtype.MOB&&p.restcard(cn.Key)>0)
                    {
                        if(c2==null){c2=c;continue;}
                        if(c3==null){c3=c;continue;}
                        if(c.cost < c2.cost){c3=c2;c2=c;}
                        if(p.restcard(cn.Key)>1)c3=c2;

                    }
                }
                    p.drawACard(c2.cardIDenum, ownplay);
                    p.drawACard(c3.cardIDenum, ownplay);

        }
	}
}