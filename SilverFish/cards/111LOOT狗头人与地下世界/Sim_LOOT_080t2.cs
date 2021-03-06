using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_080t2 : SimTemplate //* Emerald Spellstone
	{
        //Summon three 3/3_Wolves.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_077t);//Wolf

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, ownplay, false);
            p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);

			
		}
        public override void onCardIsGoingToBePlayed(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
        {

            if(hc.card.Secret == true)
            {
                p.drawACard(CardDB.cardName.greateremeraldspellstone, wasOwnCard, true);//´óÐÍ·¨Êõôä´ä
                //p.owncards.Remove(triggerhc);
                //p.removeCard(triggerhc);
            }

        }

	}

}