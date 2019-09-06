using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_539: SimTemplate //* Spiteful Summoner
    {
        // Battlecry: Reveal a spell from your deck.Summon a random minion with the same Cost.
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
        	CardDB.Card c;
        	foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
                {


                    c = CardDB.Instance.getCardDataFromID(cn.Key);

                    if (c.type == CardDB.cardtype.SPELL)
                    {
                    	p.CallKid(p.getRandomCardForManaMinion(CardDB.Instance.getCardData(c.name).cost), p.ownMinions.Count, own.own);
                    	break;
                    }
                }

        }
    }
}