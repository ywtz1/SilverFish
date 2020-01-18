using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_620t3  : SimTemplate
	{
				        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_112);
		        CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t4);
		        CardDB.Card kid2 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t5);
		        CardDB.Card kid3 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_620t6);


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.DRG_238p4, ownplay); //
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            p.equipWeapon(card,ownplay);
                        int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
            

            {
                p.callKid(kid3, posi, ownplay, false);
                p.callKid(kid3, posi, ownplay, false);
                p.equipWeapon(card,ownplay);
            }
        }
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            int posi = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
            

            {
                p.callKid(kid3, posi, own.own, false);
                p.callKid(kid3, posi, own.own, false);
                p.equipWeapon(card,own.own);
            }

        }
	}
}