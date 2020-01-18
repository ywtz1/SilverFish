using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_836 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{

            p.drawACard (CardDB.cardName.unknown,ownplay,false);
            
		}
	}
}