using System;
using System.Collections.Generic;
using System.Text;
using Silverfish.Helpers;
namespace HREngine.Bots
{
	class Sim_LOOT_507t : SimTemplate //* 法术钻石
	{
		
		
        CardDB cdb = CardDB.Instance;
        CardDB.Card kid = null; 

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int i=0;
            if (p.numberofOwnDiedMinion >= 1&&p.OwnLastDiedMinion!=CardDB.cardIDEnum.None)
            {
                int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                if(p.numberofOwnDiedMinion == 1)
                {
                    int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    kid = CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion); // Shadow of Nothing 0:1 or ownMinion
                    p.callKid(kid, posi, ownplay, false);
                }
                else
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.OwnDiedMinions)
                {
                    kid = cdb.getCardDataFromID(cn.Key);
                    
                    p.callKid(kid, pos++, ownplay);
                    i++;
                    if(i==3)
                    break;
                }
                //if (p.numberofOwnDiedMinion-i >= 1) p.callKid(kid, pos, ownplay);


                /*foreach (Handmanager.Handcard hc in p.owncards)
                {
                    if (hc.card.type == CardDB.cardtype.SPELL&&ownplay)  p.evaluatePenality += 2;
                }
                */
            }

        }
        
        
            public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
            {
                
            if(wasOwnCard&&hc.card.type == CardDB.cardtype.SPELL)
            {
                triggerhc.shenji++;
                
                //Helpfunctions.Instance.ErrorLog("###507t n "+triggerhc.shenji);
            }

            if(triggerhc.shenji>3)
                {
                    p.drawACard(CardDB.cardName.greaterdiamondspellstone, wasOwnCard, true);
                    p.removeCard(triggerhc);
                    Helpfunctions.Instance.ErrorLog("### LOOT_507t drawACard");
                }

            }
        }
    }