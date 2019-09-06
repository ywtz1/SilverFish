using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_085 : SimTemplate //* Rhok'delar
    {
        //Battlecry: If your deck has no minions, fill your_hand with Hunter_spells.

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_085);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.equipWeapon(w, ownplay);
            bool draw=true;
            CardDB.Card c;
            foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.prozis.turnDeck)
            {
                c = CardDB.Instance.getCardDataFromID(cn.Key);

                if (c.type == CardDB.cardtype.MOB)
                {
                    draw=false;
                    break;
                }
            }
            
            if(draw)
            {
                for(int i = 10 - p.owncards.Count;i > 0;i--)
                {
                    p.drawACard(CardDB.cardName.unknown, ownplay, true);
                }

            }
            
            
            //p.owncarddraw += 10 - p.owncards.Count;
        }
    }
}