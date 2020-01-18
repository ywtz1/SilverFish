using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_082 : SimTemplate //
	{

		
            CardDB.Card c = null; 
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if(target.own)
			 {
			 	//target.handcard.card.extrasimID=CardDB.cardIDEnum.TRL_082e;
			 	//c=CardDB.instance.getCardDataFromID(CardDB.cardIDEnum.TRL_082e);
			    //target.handcard.card.extrasim_card = c.sim_card;
			    target.ancestralspirit++;
			 }








			


		}

	}
}