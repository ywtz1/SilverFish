using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_025  : SimTemplate
	{
		        CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_025);
//
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.equipWeapon(card,ownplay);
		}
	}
}