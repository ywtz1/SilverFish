using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_056  : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_056);
		    public  override void inhand(Playfield p, Handmanager.Handcard hc, bool wasOwnCard, Handmanager.Handcard triggerhc)
            {
                
                if(wasOwnCard&& (TAG_RACE)hc.card.race == TAG_RACE.PIRATE)
                {
                    int posi = wasOwnCard ? p.ownMinions.Count : p.enemyMinions.Count;
                    p.callKid(kid, posi, wasOwnCard, false);
                    p.removeCard(triggerhc);
                    
                    //Helpfunctions.Instance.ErrorLog("###507t n "+triggerhc.shenji);
                }

            }
	}
}