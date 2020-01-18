using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_339 : SimTemplate //
	{

		
            CardDB.Card c = null; 
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			/*int a=p.deckrestcardbytype(3);
			if(ownplay)
			{

			if(a>=3)a=3;

			for(int i=0; i <a; i++)
			p.drawACard (CardDB.cardName.unknown,ownplay,false);
			}
			else */
			{
				p.drawACard (CardDB.cardName.unknown,ownplay,false);
				p.drawACard (CardDB.cardName.unknown,ownplay,false);
				p.drawACard (CardDB.cardName.unknown,ownplay,false);
			}








			


		}

	}
}