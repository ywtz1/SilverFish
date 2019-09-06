using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GIL_637 : SimTemplate //Ferocious Howl
	{

//    Draw a card.Gain 1 Armor for each card in your hand.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                p.minionGetArmor(p.ownHero, 5);
            }
            else
            {
                p.minionGetArmor(p.enemyHero, 5);
            }
            p.drawACard(CardDB.cardName.unknown, ownplay);
		}

	}
}