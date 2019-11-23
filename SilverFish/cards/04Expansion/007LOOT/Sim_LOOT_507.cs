using System;
using System.Collections.Generic;
using System.Text;
using SilverFish.Helpers;
namespace HREngine.Bots
{
	class Sim_LOOT_507 : SimTemplate //* Resurrect
	{
		// Summon a random friendly minion that died this game.
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
                    Helpfunctions.Instance.ErrorLog("### numberofOwnDiedMinion"+p.numberofOwnDiedMinion);
                    int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                    kid = CardDB.Instance.getCardDataFromID(p.OwnLastDiedMinion); // Shadow of Nothing 0:1 or ownMinion
                    p.CallKid(kid, posi, ownplay, false);
                }
                else
                foreach ( KeyValuePair<CardDB.cardIDEnum, int> cn in p.OwnDiedMinions)
                {
                    kid = cdb.getCardDataFromID(cn.Key);
                    
                    p.CallKid(kid, pos++, ownplay);
                    i++;
                    if(i==2)
                    break;
                }
                //if (p.numberofOwnDiedMinion-i >= 1) p.CallKid(kid, pos, ownplay);


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
                
                //Helpfunctions.Instance.ErrorLog("###507 n "+triggerhc.shenji);
            }

            if(triggerhc.shenji>3)
            {

                p.drawACard(CardDB.cardName.diamondspellstone, wasOwnCard, true);
                p.removeCard(triggerhc);
                Helpfunctions.Instance.ErrorLog("### LOOT_507 drawACard");
                
            }

        }
    }
}