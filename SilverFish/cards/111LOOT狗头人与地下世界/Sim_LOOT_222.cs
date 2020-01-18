using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_LOOT_222 : SimTemplate //candelshot
	{
        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_222);
//    euer held ist immun/, während er angreift.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            	p.equipWeapon(c,ownplay);
		}

	}
}