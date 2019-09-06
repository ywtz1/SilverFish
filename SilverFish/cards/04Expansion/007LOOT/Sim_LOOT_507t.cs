using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_507t : SimTemplate //* 法术钻石
	{
		
		
        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null; 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            //if (p.numberofOwnDiedMinion >= 1)
            {
                int i=0;
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.OwnDiedMinions)
                {
                    kid = cdb.getCardDataFromID(cn.Key);

                    
                    p.CallKid(kid, pos++, ownplay);
                    i++;
                    if(i==3||pos>7)
                    break;

                }
                //if (i=(p.numberofOwnDiedMinion-i) >= 1) p.CallKid(kid, pos, ownplay);


                /*foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.SPELL&&ownplay)  p.evaluatePenality += 2;
                    }*/
                    
                }
            }

            public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
            {
                int n=0;
                if(hc.card.type == CardDB.cardtype.SPELL)n++;

                if(n >=4)
                {
                    p.drawACard(CardDB.cardName.greaterdiamondspellstone, wasOwnCard, true);
                    p.removeCard(triggerhc);
                }

            }
        }
    }