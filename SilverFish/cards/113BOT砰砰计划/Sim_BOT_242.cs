using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
class Sim_BOT_242 : SimTemplate //* 迈拉的不稳定元素
{
    //抽取你牌库剩下的牌.
 
    public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
    {
    	for(int i =0;i<p.ownDeckSize;i++)
    	{
    		p.drawACard(CardDB.cardName.unknown, ownplay, true);
    	}

    }
}


}