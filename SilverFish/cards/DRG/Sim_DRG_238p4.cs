using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_238p4  : SimTemplate
	{
		CardDB.Card kid1 = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.DRG_238t14t3);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
        	int posi = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
        	p.CallKid(kid1, posi, ownplay, false);
        }
	}
}