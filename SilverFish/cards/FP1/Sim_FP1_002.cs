using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_FP1_002 : SimTemplate //* hauntedcreeper
	{
        //Deathrattle: Summon two 1/1 Spectral Spiders.

        CardDB.Card c = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_002t);
		
        public override void onDeathrattle(Playfield p, Minion m)
        {
            p.CallKid(c, m.zonepos-1, m.own);
            p.CallKid(c, m.zonepos-1, m.own);
        }
	}
}