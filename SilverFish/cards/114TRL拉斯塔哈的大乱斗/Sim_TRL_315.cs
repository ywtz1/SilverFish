using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_315 : SimTemplate //火焰狂人</Tag>每当你的英雄技能消灭一个随从，抽一张牌

	{
		CardDB.Card c = null; 
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool ownplay, Minion m)
        {
        	int n= p.HeroPowerkilledaminion;
        	if( p.HeroPowerkilledaminion > n)
        	{

        		p.drawACard(CardDB.cardName.unknown,ownplay,false) ;
        		n=p.HeroPowerkilledaminion;
        	}
				



		}
	}
}