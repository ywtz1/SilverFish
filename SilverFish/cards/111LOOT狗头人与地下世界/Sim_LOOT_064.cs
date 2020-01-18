using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_064 : SimTemplate//
    {
        public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {
            int n=p.ueberladung;
            int i=0;
            

            if(p.ueberladung-n < 0)i+=p.ueberladung;
            else i+=(p.ueberladung-n) ;

            if(i>=4)
            {
                p.drawACard(CardDB.cardName.sapphirespellstone, wasOwnCard, true);
                p.removeCard(triggerhc);
            }

        }


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	if(target.own)
        	{
        		int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(target.handcard.card, pos, ownplay);
        		//m.handcard.card.name

        	}




            
            
        }


    }
}
