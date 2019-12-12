using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_610t2  : SimTemplate
	{
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_112);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            
            p.setNewHeroPower(CardDB.cardIDEnum.DRG_238p2, own.own); //
            if (own.own) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            
            if(p.nqiqiu>=4)
            {
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.equipWeapon(card,own.own);
            }
            else
            {
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
            }

        }
	}
}