using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_238p2  : SimTemplate
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

        	p.drawACard(CardDB.cardName.facelesslackey, ownplay, true);
        }
	}
}