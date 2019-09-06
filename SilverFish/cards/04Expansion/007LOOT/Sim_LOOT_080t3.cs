using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
    class Sim_LOOT_080t3 : SimTemplate //* Greater Emerald Spellstone
	{
        //Summon four 3/3_Wolves.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.LOOT_077t);//Wolf

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int pos =(ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.CallKid(kid, pos, ownplay, false);
            p.CallKid(kid, pos, ownplay);
			p.CallKid(kid, pos, ownplay);
			p.CallKid(kid, pos, ownplay);
			
		}
	}
}