using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_610t3  : SimTemplate
	{	CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_112);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            
            p.setNewHeroPower(CardDB.cardIDEnum.DRG_238p2, ownplay); //
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
            
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.drawACard(CardDB.cardName.unknown, true, false);
                p.equipWeapon(card,ownplay);

        }
	}
}