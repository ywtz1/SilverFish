using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DAL_400 : SimTemplate //* Flame Lance
	{
		//Deal 8 damage to a minion.
		
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardName.witchylackey, own.own,true);
		}
	}
}