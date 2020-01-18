using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_211 : SimTemplate //* Elven Minstrel
    {
        // Combo: Draw 2 minions from your deck.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			if (p.cardsPlayedThisTurn >= 1)
			{
				CardDB.Card c;
				int count = 0;
				foreach (KeyValuePair<CardDB.cardIDEnum, int> cid in p.prozis.turnDeck)
				{
					c = CardDB.Instance.getCardDataFromID(cid.Key);
					for (int i = 0; i < cid.Value; i++)
					{
						p.drawACard(c.name, true);
						count++;
						if (count > 1) break;
					}	
					if (count > 1) break;
				}
				
			}	
        }
    }
}