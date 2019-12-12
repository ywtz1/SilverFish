using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_620  : SimTemplate
	{
		        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_112);
		        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t4);
		        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t5);
		        CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t6);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            
            p.setNewHeroPower(CardDB.cardIDEnum.DRG_238p4, own.own); //
            if (own.own) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            int posi = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
            
            if(p.nqiqiu>=4)
            {
                p.CallKid(kid3, posi, own.own, false);
                p.CallKid(kid3, posi, own.own, false);
                p.equipWeapon(card,own.own);
            }
            else if (p.nqiqiu>=2)
            {
                p.CallKid(kid2, posi, own.own, false);
                p.CallKid(kid2, posi, own.own, false);
            }
            else 
            {
                p.CallKid(kid1, posi, own.own, false);
                p.CallKid(kid1, posi, own.own, false);
            }
        }
	}
}