using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_909 : SimTemplate //* 水晶学
	{
		// 从你的牌库中抽两张攻击力为1的随从牌
            CardDB.Card c = null;       CardDB.Card c2 = null;  CardDB.Card c3 = null;    // 
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

                /*foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {
                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.type == CardDB.cardtype.MOB&&p.restcard(cn.Key)>0&&c.Attack==1)
                    {
                        if(c2==null) c2=c;
                        else if(c3==null) c3=c;
                        if(p.restcard(cn.Key)>1)c3=c2;

                    }
                }
                if(c2!=null)p.drawACard(c2.cardIDenum, ownplay);
                if(c3!=null)p.drawACard(c3.cardIDenum, ownplay);*/
                p.drawACard(CardDB.cardName.unknown, ownplay);
                p.drawACard(CardDB.cardName.unknown, ownplay);


        }
	}
}