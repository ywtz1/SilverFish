using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_055  : SimTemplate
	{
		CardDB.Card wp = null;
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int n=0;
            foreach (KeyValuePair<CardDB.cardIDEnum, int> e in Probabilitymaker.Instance.ownCardsOut)
            {
                CardDB.Card c = CardDB.Instance.getCardDataFromID(e.Key);
                if(c.type==CardDB.cardtype.WEAPON)
                {
                	wp=c;
                	n+=e.Value;
                	//break;
                }
            }
            if(n>1||(n==1&&(p.ownWeapon.Durability==0||p.ownWeapon.name==CardDB.cardName.unknown)))
            p.equipWeapon(wp,own.own);
        }
	}
}