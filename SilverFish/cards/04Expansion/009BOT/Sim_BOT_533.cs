using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BOT_533 : SimTemplate //*Menacing Nimbus
//Battlecry:Add a random Elemental to your hand.
{

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{



                   p.drawACard (CardDB.cardName.unknown,own.own,true);
		}

	}
}