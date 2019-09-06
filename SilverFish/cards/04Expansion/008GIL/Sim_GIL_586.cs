using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_586 : SimTemplate //* Earthen Might
//Give a minion +2/+2.If it's an Elemental,add a random Elemental to your hand.

	{
		public override void onCardPlay(Playfield p,bool ownplay,Minion target,int choice)
		{




			p.minionGetBuffed(target,2,2);
			if((TAG_RACE)target.handcard.card.race == TAG_RACE.ELEMENTAL)
			p.drawACard(CardDB.cardName.unknown,ownplay,true) ;
		}

	}
}