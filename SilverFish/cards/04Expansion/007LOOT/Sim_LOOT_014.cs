using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_014 : SimTemplate //* Kobold Librarian
	{

//    Battlecry: Draw a card. Deal 2 damage to your hero.
  public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardName.unknown, own.own);
            p.minionGetDamageOrHeal(own.own ? p.ownHero : p.enemyHero, 2);

		}


	}
}