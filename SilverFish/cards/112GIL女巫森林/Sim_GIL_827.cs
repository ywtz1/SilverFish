using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_827 : SimTemplate //* Blink Fox
	{
		//Battlecry: Add a random card to your hand (from your opponent's class).
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardName.unknown, own.own, true);
		}
	}
}